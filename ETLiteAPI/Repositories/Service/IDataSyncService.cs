using ETLiteAPI.Models;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

public interface IDataSyncService
{
    public dynamic SyncData<T>(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string sql) where T : class, new();
}
