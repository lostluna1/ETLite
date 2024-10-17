using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Services;
using FreeSql;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// ����ʱ���������ļ�
var configurationBuilder = new ConfigurationBuilder()
    .SetBasePath(AppContext.BaseDirectory) // ʹ������Ŀ¼·��
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables();
var configuration = configurationBuilder.Build();

// �����ɵ�������ӵ�����������
builder.Services.AddSingleton<IConfiguration>(configuration);

// Add services to the container.
builder.Services.AddSingleton<IDictionary<string, IFreeSql>>(provider =>
{
    var config = provider.GetRequiredService<IConfiguration>();
    var connections = config.GetSection("Connections").Get<Dictionary<string, ETLiteAPI.Models.ConnectionInfo>>();

    var freeSqlInstances = new Dictionary<string, IFreeSql>();

    if (connections == null)
    {
        throw new InvalidOperationException("δ�ҵ��κ����ݿ��������á�");
    }

    foreach (var connection in connections)
    {
        try
        {
            var connectionString = Connector.BuildConnectionString(connection.Value);
            var dataType = Connector.GetDataType(connection.Value.DatabaseType);
            var freeSql = new FreeSqlBuilder()
            .UseMonitorCommand(cmd => Debug.WriteLine($"Sql��{cmd.CommandText}"))
                .UseConnectionString(dataType, connectionString)
                .Build();
            freeSqlInstances[connection.Key] = freeSql;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"�޷����ӵ����ݿ�: {connection.Key}", ex);
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