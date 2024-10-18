using System.Reflection;
using ETLiteAPI.Models;
using FreeSql;
using FreeSql.DatabaseModel;
using FreeSql.Internal.Model;
using Microsoft.Extensions.Logging;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;
using FreeSql.Extensions.ZeroEntity;
using static FreeSql.Extensions.ZeroEntity.TableDescriptor;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;
using System;
using ETLiteAPI.FreeSqlUtilities;
using Hangfire;
using Hangfire.Storage.Monitoring;

namespace ETLiteAPI.Services;
public class DataSyncService(/*IConfiguration configuration,*/ ILogger<DataSyncService> logger, IDictionary<string, IFreeSql> freeSqlInstances) : IDataSyncService
{
    //private readonly IConfiguration _configuration = configuration;
    private readonly ILogger<DataSyncService> _logger = logger;
    private readonly IDictionary<string, IFreeSql> _freeSqlInstances = freeSqlInstances;

    [AutomaticRetry(Attempts = 3)] // �Զ�����3��
    [DisableConcurrentExecution(timeoutInSeconds: 300)] // ��ֹ����ִ�У���ʱʱ��Ϊ300�루5���ӣ�
    public ResultModels SyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null)
    {
        try
        {
            _logger.LogInformation("��ʼ����ͬ����Դ���ݿ����: {TableName}", tableName);

            // ��ȡԴ���ݿ��Ŀ�����ݿ�� FreeSql ʵ��
            var sourceFsql = _freeSqlInstances[sourceConnName];
            var targetFsql = _freeSqlInstances[targetConnName];

            // ��ʵ���ѯԴ���ݿ��е�����
            var sourceData = sourceFsql.Ado.Query<Dictionary<string, object>>(sql);

            _logger.LogInformation("�ɹ���ѯԴ���ݿ��е�����: {TableName}", tableName);

            if (sourceData.Count == 0)
            {
                return new ResultModels
                {
                    Code = 1,
                    Message = "Failed: No Results",
                    Rows = 0
                };
            }

            // ��̬����ʵ������
            var dynamicEntityBuilder = targetFsql.CodeFirst.DynamicEntity(tableName, new TableAttribute { Name = tableName });

            foreach (var key in sourceData[0].Keys)
            {
                var value = sourceData[0][key];
                var type = value?.GetType() ?? typeof(string); // ���ֵΪ null��Ĭ������Ϊ string

                // ��� primaryKeys �Ƿ������ǰ��
                var isPrimaryKey = primaryKeys?.Contains(key) ?? false;

                dynamicEntityBuilder.Property(key, type, new ColumnAttribute
                {
                    IsNullable = !isPrimaryKey, // �����������������Ϊ null
                    IsPrimary = isPrimaryKey
                });
            }
            var dynamicEntity = dynamicEntityBuilder.Build();

            // ����б�Ҫ���뽫 dynamicEntity ��������

            // ͬ��Ŀ�����ݿ��ṹ
            targetFsql.CodeFirst.SyncStructure(dynamicEntity.Type);

            // �����ݲ��뵽Ŀ����У����������²���
            var rowsAffected = 0;
            var batchInsertOrUpdate = targetFsql.InsertOrUpdate<object>()
                .AsType(dynamicEntity.Type)
                .SetSource(sourceData.Select(item => dynamicEntity.CreateInstance(item)).ToList());

            rowsAffected = batchInsertOrUpdate.ExecuteAffrows();// �������²���

            _logger.LogInformation("����ͬ�����: {TableName}", tableName);
            return new ResultModels
            {
                Code = 0,
                Message = "Success",
                Rows = rowsAffected
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "����ͬ�������з�������");
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

    public string ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null)
    {
        // ����һ��Ψһ�� jobId
        var jobId = Guid.NewGuid().ToString();

        // ʹ�����ɵ� jobId ��������¶�ʱ����
        RecurringJob.AddOrUpdate(jobId, () => SyncData(sourceConnName, targetConnName, tableName, sql, primaryKeys), "*/1 * * * *");

        _logger.LogInformation("��ʼ��ӡ��Ϣ");

        var jobDetails = GetJobDetails(jobId);
        _logger.LogInformation("Job Details: JobId={JobId}, CreatedAt={CreatedAt}, State={State}, Properties={Properties}",
            jobId, jobDetails.CreatedAt, jobDetails.State, JsonConvert.SerializeObject(jobDetails.Properties));

        return jobId;
    }


    public ExtendedJobDetailsDto GetJobDetails(string jobId)
    {
        using var connection = JobStorage.Current.GetConnection();
        var jobData = connection.GetJobData(jobId);
        var stateData = connection.GetStateData(jobId);

        if (jobData == null || stateData == null)
        {
            _logger.LogWarning("Job data or state data for jobId {JobId} is null.", jobId);
            return new ExtendedJobDetailsDto
            {
                CreatedAt = null,
                State = "Unknown",
                Properties = new Dictionary<string, string>()
            };
        }

        return new ExtendedJobDetailsDto
        {
            CreatedAt = jobData.CreatedAt,
            State = stateData.Name,
            Properties = stateData.Data
        };
    }



    public class ExtendedJobDetailsDto : JobDetailsDto
    {
        public string State
        {
            get; set;
        }
    }

}
