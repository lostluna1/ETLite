using ETLiteAPI.FreeSqlUtilities;
using ETLiteAPI.Models;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

public interface IDataSyncService
{
    //public string GetTableDataAsJson(ConnectionInfo sourceInfo, string tableName);
    public ResultModels SyncData(string sourceConnName, string targetConnName, string tableName, string sql, List<string>? primaryKeys = null);

    //public dynamic SyncData(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string tableName, string sql);
}
