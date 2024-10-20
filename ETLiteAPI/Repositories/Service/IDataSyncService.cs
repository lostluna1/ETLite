using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Models;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

public interface IDataSyncService
{
    ResultModels SyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null);
    string ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, string jobName, List<string>? primaryKeys = null);
}

