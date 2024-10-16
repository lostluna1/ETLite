using System.Reflection;
using ETLiteAPI.Models;
using ETLiteAPI.Models.DBFirstEntities;
using FreeSql;
using FreeSql.DatabaseModel;
using FreeSql.Internal.Model;
using Microsoft.Extensions.Logging;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;
using FreeSql.Extensions.ZeroEntity;
using static FreeSql.Extensions.ZeroEntity.TableDescriptor;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Services;
public class DataSyncService : IDataSyncService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<DataSyncService> _logger;

    public DataSyncService(IConfiguration configuration, ILogger<DataSyncService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }
    public dynamic SyncData(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string tableName,string sql)
    {
        try
        {
            _logger.LogInformation("��ʼ����ͬ����Դ���ݿ����: {TableName}", tableName);

            // ����Դ���ݿ�����
            var sourceConnectionString = BuildConnectionString(sourceInfo);
            var sourceDataType = GetDataType(sourceInfo.DatabaseType);
            var sourceFsql = new FreeSqlBuilder()
                .UseConnectionString(sourceDataType, sourceConnectionString)
                .Build();

            _logger.LogInformation("Դ���ݿ������ַ���: {ConnectionString}", sourceConnectionString);

            // ����Ŀ�����ݿ�����
            var targetConnectionString = BuildConnectionString(targetInfo);
            var targetDataType = GetDataType(targetInfo.DatabaseType);
            var targetFsql = new FreeSqlBuilder()
                .UseConnectionString(targetDataType, targetConnectionString)
                .Build();

            _logger.LogInformation("Ŀ�����ݿ������ַ���: {ConnectionString}", targetConnectionString);

            // ��ȡָ���������Ϣ
            var sourceTable = sourceFsql.DbFirst.GetTableByName(tableName);
            if (sourceTable == null)
            {
                throw new Exception($"Դ���ݿ��в����ڱ�: {tableName}");
            }

            _logger.LogInformation("�ɹ���ȡԴ���ݿ����Ϣ: {TableName}", tableName);

            // ��̬����ʵ������
            var dynamicEntityBuilder = targetFsql.CodeFirst.DynamicEntity(tableName, new TableAttribute { Name = tableName });
            foreach (var column in sourceTable.Columns)
            {
                dynamicEntityBuilder.Property(column.Name, column.CsType, new ColumnAttribute
                {
                    IsIdentity = column.IsIdentity,
                    IsPrimary = column.IsPrimary,
                    StringLength = column.MaxLength,
                    IsNullable = !column.IsPrimary // ����Դ���ݿ����ֶ����ã������ֶβ�����Ϊ�գ������ֶ�����Ϊ��
                });
            }
            var dynamicEntity = dynamicEntityBuilder.Build();

            // ����б�Ҫ���뽫 dynamicEntity ��������

            // ��ѯԴ���ݿ��е�����
            var sourceData = sourceFsql.Ado.Query<Dictionary<string, object>>(sql);

            _logger.LogInformation("�ɹ���ѯԴ���ݿ��е�����: {TableName}", tableName);

            // ͬ��Ŀ�����ݿ��ṹ
            targetFsql.CodeFirst.SyncStructure(dynamicEntity.Type);

            // �����ݲ��뵽Ŀ�����
            foreach (var item in sourceData)
            {
                // ��鲢���� NULL ֵ
                foreach (var column in sourceTable.Columns)
                {
                    if (column.IsPrimary && item[column.Name] == null)
                    {
                        throw new Exception($"�ֶ� {column.Name} ������Ϊ NULL");
                    }
                }

                var obj = dynamicEntity.CreateInstance(item);
                targetFsql.Insert<object>().AsType(dynamicEntity.Type).AppendData(obj).ExecuteAffrows();
            }

            _logger.LogInformation("����ͬ�����: {TableName}", tableName);
            return "����ͬ�����";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "����ͬ�������з�������");
            throw;
        }
    }



    /*    public dynamic SyncData(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string sql)
        {
            try
            {
                // ����Դ���ݿ�����
                var sourceConnectionString = BuildConnectionString(sourceInfo);
                var sourceDataType = GetDataType(sourceInfo.DatabaseType);
                var sourceFsql = new FreeSqlBuilder()
                    .UseConnectionString(sourceDataType, sourceConnectionString)
                    .Build();

                // ����Ŀ�����ݿ�����
                var targetConnectionString = BuildConnectionString(targetInfo);
                var targetDataType = GetDataType(targetInfo.DatabaseType);
                var targetFsql = new FreeSqlBuilder()
                    .UseConnectionString(targetDataType, targetConnectionString)
                    .Build();

                //v3.2.695 emit ��̬����ʵ������
                var table = targetFsql.CodeFirst.DynamicEntity("user", new TableAttribute { Name = "User" })
                    .Property("id", typeof(int), new ColumnAttribute { IsIdentity = true, IsPrimary = true })
                    .Property("Name", typeof(string), new ColumnAttribute { StringLength = 32 })
                    .Build();

                //����б�Ҫ���뽫 table ��������

                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict["id"] = 1;
                dict["Name"] = "xxx";
                targetFsql.CodeFirst.SyncStructure(table.Type);
                //���ֵ�ת���� type ��Ӧ�� object
                object obj = table.CreateInstance(dict);

                //����
                targetFsql.Insert<object>().AsType(table.Type).AppendData(obj).ExecuteAffrows();


                //�ȵ�...

                return "����ͬ�����";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "����ͬ�������з�������");
                throw;
            }
        }
    */


    private string BuildConnectionString(ConnectionInfo info)
    {
        return info.DatabaseType switch
        {
            "MySQL" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "PostgreSQL" => $"Host={info.ServerAddress};Database={info.DatabaseName};Username={info.Username};Password={info.Password};",
            "SQL Server" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "Oracle" => $"User Id={info.Username};Password={info.Password};Data Source={info.ServerAddress}/{info.DatabaseName};",
            _ => throw new NotSupportedException($"��֧�ֵ����ݿ�����: {info.DatabaseType}")
        };
    }

    private DataType GetDataType(string? databaseType)
    {
        return databaseType switch
        {
            "MySQL" => DataType.MySql,
            "PostgreSQL" => DataType.PostgreSQL,
            "SQL Server" => DataType.SqlServer,
            "Oracle" => DataType.Oracle,
            _ => throw new NotSupportedException($"��֧�ֵ����ݿ�����: {databaseType}")
        };
    }
}
