namespace ETLiteAPI.Repositories.Service;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

public interface IConnectionService
{
    Task<List<ConnectionInfo>> GetConnectionsAsync();
    Task SaveConnectionAsync(ConnectionInfo connection);
    Task UpdateConnectionAsync(string id, ConnectionInfo connection);
    Task<bool> DeleteConnectionAsync(string id);
}
