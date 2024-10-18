using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Models;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

public interface IDataSyncService
{
    public ResultModels SyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null);
    public string ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null);
    //public void ScheduleSyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null);
}

