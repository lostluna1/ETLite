using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Repositories.Service;
using ETLiteAPI.Services;
using FreeSql;
using Hangfire;
using Hangfire.Console;
using Hangfire.SqlServer;
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
builder.Services.AddTransient<IConnectionService, ConnectionService>();
builder.Services.AddTransient<IHangfireJobsService, HangfireJobsService>();

#region FreeSql
var freeSqlDict = new Dictionary<string, IFreeSql>
{
    { "Default", new FreeSqlBuilder()
        .UseConnectionString(DataType.SqlServer, builder.Configuration.GetConnectionString("DefaultConnection"))
        .Build() }
};

// ��� FreeSql
builder.Services.AddSingleton<IDictionary<string, IFreeSql>>(freeSqlDict);
#endregion

builder.Services.AddTransient<IDataSyncService, DataSyncService>();

// ע�� AES ���ܷ���
var aesKey = configuration["AesEncryption:Key"];
var aesIv = configuration["AesEncryption:IV"];

if (string.IsNullOrEmpty(aesKey) || string.IsNullOrEmpty(aesIv))
{
    throw new InvalidOperationException("AES ���ܷ���� Key �� IV δ���á�");
}

builder.Services.AddSingleton<IAesEncryptionService>(provider => (IAesEncryptionService)new AesEncryptionService(aesKey, aesIv));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ���� Hangfire ʹ�� SQL Server ��Ϊ�־û��洢
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

// ��ʼ�� FreeSql ����
await InitializeFreeSqlConnections(app.Services);

async Task InitializeFreeSqlConnections(IServiceProvider services)
{
    using var scope = services.CreateScope();
    var provider = scope.ServiceProvider;
    var connectionService = provider.GetRequiredService<IConnectionService>();
    var connections = await connectionService.GetConnectionsAsync();

    foreach (var connection in connections)
    {
        try
        {
            var connectionString = Connector.BuildConnectionString(connection);
            var dataType = Connector.GetDataType(connection.DatabaseType);
            var freeSql = new FreeSqlBuilder()
                .UseMonitorCommand(cmd => Debug.WriteLine($"Sql��{cmd.CommandText}"))
                .UseConnectionString(dataType, connectionString)
                .Build();
            freeSqlDict[connection.ConnectionName] = freeSql;
        }
        catch (Exception ex)
        {
            throw new InvalidOperationException($"�޷����ӵ����ݿ�: {connection.ConnectionName}", ex);
        }
    }
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// ���� Hangfire �Ǳ��
app.UseHangfireDashboard("/hangfire");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
