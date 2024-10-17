using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Services;
using FreeSql;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
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

// Add services to the container.
builder.Services.AddSingleton<IDictionary<string, IFreeSql>>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    var connections = config.GetSection("Connections").Get<Dictionary<string, ETLiteAPI.Models.ConnectionInfo>>();

    var freeSqlInstances = new Dictionary<string, IFreeSql>();

    if (connections == null)
    {
        throw new InvalidOperationException("未找到任何数据库连接配置。");
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
});
builder.Services.AddTransient<IDataSyncService, DataSyncService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();