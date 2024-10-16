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
            _logger.LogInformation("开始数据同步，源数据库表名: {TableName}", tableName);

            // 建立源数据库连接
            var sourceConnectionString = BuildConnectionString(sourceInfo);
            var sourceDataType = GetDataType(sourceInfo.DatabaseType);
            var sourceFsql = new FreeSqlBuilder()
                .UseConnectionString(sourceDataType, sourceConnectionString)
                .Build();

            _logger.LogInformation("源数据库连接字符串: {ConnectionString}", sourceConnectionString);

            // 建立目标数据库连接
            var targetConnectionString = BuildConnectionString(targetInfo);
            var targetDataType = GetDataType(targetInfo.DatabaseType);
            var targetFsql = new FreeSqlBuilder()
                .UseConnectionString(targetDataType, targetConnectionString)
                .Build();

            _logger.LogInformation("目标数据库连接字符串: {ConnectionString}", targetConnectionString);

            // 获取指定表的列信息
            var sourceTable = sourceFsql.DbFirst.GetTableByName(tableName);
            if (sourceTable == null)
            {
                throw new Exception($"源数据库中不存在表: {tableName}");
            }

            _logger.LogInformation("成功获取源数据库表信息: {TableName}", tableName);

            // 动态创建实体类型
            var dynamicEntityBuilder = targetFsql.CodeFirst.DynamicEntity(tableName, new TableAttribute { Name = tableName });
            foreach (var column in sourceTable.Columns)
            {
                dynamicEntityBuilder.Property(column.Name, column.CsType, new ColumnAttribute
                {
                    IsIdentity = column.IsIdentity,
                    IsPrimary = column.IsPrimary,
                    StringLength = column.MaxLength,
                    IsNullable = !column.IsPrimary // 保留源数据库表的字段设置，主键字段不允许为空，其他字段允许为空
                });
            }
            var dynamicEntity = dynamicEntityBuilder.Build();

            // 如果有必要，请将 dynamicEntity 缓存起来

            // 查询源数据库中的数据
            var sourceData = sourceFsql.Ado.Query<Dictionary<string, object>>(sql);

            _logger.LogInformation("成功查询源数据库中的数据: {TableName}", tableName);

            // 同步目标数据库表结构
            targetFsql.CodeFirst.SyncStructure(dynamicEntity.Type);

            // 将数据插入到目标表中
            foreach (var item in sourceData)
            {
                // 检查并处理 NULL 值
                foreach (var column in sourceTable.Columns)
                {
                    if (column.IsPrimary && item[column.Name] == null)
                    {
                        throw new Exception($"字段 {column.Name} 不允许为 NULL");
                    }
                }

                var obj = dynamicEntity.CreateInstance(item);
                targetFsql.Insert<object>().AsType(dynamicEntity.Type).AppendData(obj).ExecuteAffrows();
            }

            _logger.LogInformation("数据同步完成: {TableName}", tableName);
            return "数据同步完成";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "数据同步过程中发生错误");
            throw;
        }
    }



    /*    public dynamic SyncData(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string sql)
        {
            try
            {
                // 建立源数据库连接
                var sourceConnectionString = BuildConnectionString(sourceInfo);
                var sourceDataType = GetDataType(sourceInfo.DatabaseType);
                var sourceFsql = new FreeSqlBuilder()
                    .UseConnectionString(sourceDataType, sourceConnectionString)
                    .Build();

                // 建立目标数据库连接
                var targetConnectionString = BuildConnectionString(targetInfo);
                var targetDataType = GetDataType(targetInfo.DatabaseType);
                var targetFsql = new FreeSqlBuilder()
                    .UseConnectionString(targetDataType, targetConnectionString)
                    .Build();

                //v3.2.695 emit 动态创建实体类型
                var table = targetFsql.CodeFirst.DynamicEntity("user", new TableAttribute { Name = "User" })
                    .Property("id", typeof(int), new ColumnAttribute { IsIdentity = true, IsPrimary = true })
                    .Property("Name", typeof(string), new ColumnAttribute { StringLength = 32 })
                    .Build();

                //如果有必要，请将 table 缓存起来

                Dictionary<string, object> dict = new Dictionary<string, object>();
                dict["id"] = 1;
                dict["Name"] = "xxx";
                targetFsql.CodeFirst.SyncStructure(table.Type);
                //将字典转化成 type 对应的 object
                object obj = table.CreateInstance(dict);

                //插入
                targetFsql.Insert<object>().AsType(table.Type).AppendData(obj).ExecuteAffrows();


                //等等...

                return "数据同步完成";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "数据同步过程中发生错误");
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
            _ => throw new NotSupportedException($"不支持的数据库类型: {info.DatabaseType}")
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
            _ => throw new NotSupportedException($"不支持的数据库类型: {databaseType}")
        };
    }
}
