using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Services;
using FreeSql;
using Hangfire;
using Hangfire.Console;
using Hangfire.SqlServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// 运行时生成配置文件
var configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory) // 使用生成目录路径
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();
var configuration = configurationBuilder.Build();

// 将生成的配置添加到服务容器中
builder.Services.AddSingleton<IConfiguration>(configuration);

#region FreeSql
// Add services to the container.
/*builder.Services.AddSingleton<IDictionary<string, IFreeSql>>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    var connections = config.GetSection("Connections").Get<Dictionary<string, ETLiteAPI.Models.ConnectionInfo>>();

    var freeSqlInstances = new Dictionary<string, IFreeSql>();

    if (connections == null)
    {
        //throw new InvalidOperationException("未找到任何数据库连接配置。");
    }

    foreach (var connection in connections)
    {
        try
        {
            var connectionString = Connector.BuildConnectionString(connection.Value);
            var dataType = Connector.GetDataType(connection.Value.DatabaseType);
            var freeSql = new FreeSqlBuilder()
            .UseMonitorCommand(cmd => Debug.WriteLine($"Sql：{cmd.CommandText}"))
                .UseConnectionString(dataType, connectionString)
                .Build();
            freeSqlInstances[connection.Key] = freeSql;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"无法连接到数据库: {connection.Key}", ex);
        }
    }

    return freeSqlInstances;
});*/
// 添加 FreeSql
var freeSqlDict = new Dictionary<string, IFreeSql>
{
    { "Default", new FreeSqlBuilder()
        .UseConnectionString(DataType.SqlServer, builder.Configuration.GetConnectionString("DefaultConnection"))
        .Build() }
};

builder.Services.AddSingleton<IDictionary<string, IFreeSql>>(freeSqlDict);


#endregion


builder.Services.AddTransient<IDataSyncService, DataSyncService>();

// 添加数据保护服务
builder.Services.AddDataProtection();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 配置 Hangfire 使用 SQL Server 作为持久化存储
builder.Services.AddHangfire(config =>
{
    config.UseSqlServerStorage(configuration.GetConnectionString("HangfireConnection"), new SqlServerStorageOptions
    {
        CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
        SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
        QueuePollInterval = TimeSpan.Zero,
        UseRecommendedIsolationLevel = true,
        DisableGlobalLocks = true
    }).UseConsole(new ConsoleOptions()
    {
        BackgroundColor = "#000079"
    });


});
builder.Services.AddHangfireServer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// 配置 Hangfire 仪表板
app.UseHangfireDashboard("/hangfire");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
