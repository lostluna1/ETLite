using ETL.Models;

namespace ETL.Contracts.Services;

public interface IDBConfigService
{
    Task<List<ConnectionInfo>> LoadSavedConnectionsAsync();
    Task<bool> AddOrUpdateConnectionAsync(ConnectionInfo connectionInfo, bool isNewConnection);
    Task<bool> DeleteConnectionAsync(string connectionId);
    Task<bool> ConnectToDatabaseAsync(FreeSql.DataType dbType, string connectionString);
}
