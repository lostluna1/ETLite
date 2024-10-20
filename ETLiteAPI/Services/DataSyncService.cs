using FreeSql;
using FreeSql.DataAnnotations;
using ETLiteAPI.FreeSqlUtilities;
using Hangfire;

namespace ETLiteAPI.Services;
public class DataSyncService(ILogger<DataSyncService> logger, IDictionary<string, IFreeSql> freeSqlInstances) : IDataSyncService
{
    //private readonly IConfiguration _configuration = configuration;
    private readonly ILogger<DataSyncService> _logger = logger;
    private readonly IDictionary<string, IFreeSql> _freeSqlInstances = freeSqlInstances;

    [AutomaticRetry(Attempts = 3)] // 自动重试3次
    [DisableConcurrentExecution(timeoutInSeconds: 300)] // 禁止并发执行，超时时间为300秒（5分钟）
    public ResultModels SyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null)
    {
        try
        {
            _logger.LogInformation("开始数据同步，源数据库表名: {TableName}", tableName);

            // 获取源数据库和目标数据库的 FreeSql 实例
            var sourceFsql = _freeSqlInstances[sourceConnName];
            var targetFsql = _freeSqlInstances[targetConnName];

            // 无实体查询源数据库中的数据
            var sourceData = sourceFsql.Ado.Query<Dictionary<string, object>>(sql);

            var sourcedata = sourceFsql.Select<object>().WithSql(sql).ToList();

            _logger.LogInformation("成功查询源数据库中的数据: {TableName}", tableName);

            if (sourceData.Count == 0)
            {
                return new ResultModels
                {
                    Code = 1,
                    Message = "Failed: No Results",
                    Rows = 0
                };
            }

            // 动态创建实体类型
            var dynamicEntityBuilder = targetFsql.CodeFirst.DynamicEntity(tableName, new TableAttribute { Name = tableName });

            foreach (var key in sourceData[0].Keys)
            {
                var value = sourceData[0][key];
                var type = value?.GetType() ?? typeof(string); // 如果值为 null，默认类型为 string

                // 检查 primaryKeys 是否包含当前列
                var isPrimaryKey = primaryKeys?.Contains(key) ?? false;

                dynamicEntityBuilder.Property(key, type, new ColumnAttribute
                {
                    IsNullable = !isPrimaryKey, // 如果是主键，则不允许为 null
                    IsPrimary = isPrimaryKey
                });
            }
            var dynamicEntity = dynamicEntityBuilder.Build();

            // 如果有必要，请将 dynamicEntity 缓存起来

            // 同步目标数据库表结构
            targetFsql.CodeFirst.SyncStructure(dynamicEntity.Type);

            // 将数据插入到目标表中，按主键更新插入
            var rowsAffected = 0;
            var batchInsertOrUpdate = targetFsql.InsertOrUpdate<object>()
                .AsType(dynamicEntity.Type)
                .SetSource(sourceData.Select(item => dynamicEntity.CreateInstance(item)).ToList());

            rowsAffected = batchInsertOrUpdate.ExecuteAffrows();// 批量更新插入

            _logger.LogInformation("数据同步完成: {TableName}", tableName);
            return new ResultModels
            {
                Code = 0,
                Message = "Success",
                Rows = rowsAffected
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "数据同步过程中发生错误");
            return new ResultModels
            {
                Code = 1,
                Message = $"Failed: {ex.Message}",
                Rows = 0
            };
        }
    }

    //public void ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null)
    //{
    //    RecurringJob.AddOrUpdate(() => SyncData(sourceConnName, targetConnName, tableName, sql, primaryKeys), "*/1 * * * *"); 
    //}

    //public string ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null)
    //{
    //    var jobId = Guid.NewGuid().ToString();

    //    RecurringJob.AddOrUpdate(jobId, () => SyncData(sourceConnName, targetConnName, tableName, sql, primaryKeys), "*/1 * * * *");

    //    return jobId;
    //}

    public string ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, string jobName, List<string>? primaryKeys = null)
    {
        var uniqueJobName = $"{jobName}_{Guid.NewGuid()}";
        RecurringJob.AddOrUpdate(uniqueJobName, () => SyncData(sourceConnName, targetConnName, tableName, sql, primaryKeys), "*/1 * * * *");

        return jobName;
    }


}
