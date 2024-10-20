using System.Security.Cryptography;
using ETLiteAPI.Repositories.Service;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

namespace ETLiteAPI.Services;

public class ConnectionService : IConnectionService
{
    private readonly IDictionary<string, IFreeSql> _freeSqlDict;
    private readonly IAesEncryptionService _aesEncryptionService;

    public ConnectionService(IDictionary<string, IFreeSql> freeSqlDict, IAesEncryptionService aesEncryptionService)
    {
        _freeSqlDict = freeSqlDict;
        _aesEncryptionService = aesEncryptionService;
    }

    private IFreeSql GetFreeSqlInstance(string connectionName)
    {
        if (_freeSqlDict.TryGetValue(connectionName, out var freeSql))
        {
            return freeSql;
        }
        throw new KeyNotFoundException($"未找到名为 {connectionName} 的数据库连接实例。");
    }

    public async Task<List<ConnectionInfo>> GetConnectionsAsync()
    {
        var freeSql = GetFreeSqlInstance("Default");
        var connections = await freeSql.Select<ConnectionInfo>().ToListAsync();
        foreach (var connection in connections)
        {
            try
            {
                connection.DatabaseType = _aesEncryptionService.Decrypt(connection.DatabaseType ?? string.Empty);
                connection.ServerAddress = _aesEncryptionService.Decrypt(connection.ServerAddress ?? string.Empty);
                connection.DatabaseName = _aesEncryptionService.Decrypt(connection.DatabaseName ?? string.Empty);
                connection.Username = _aesEncryptionService.Decrypt(connection.Username ?? string.Empty);
                connection.Password = _aesEncryptionService.Decrypt(connection.Password ?? string.Empty);
            }
            catch (CryptographicException ex)
            {
                throw new Exception("解密连接信息时发生错误", ex);
            }
        }
        return connections;
    }

    public async Task SaveConnectionAsync(ConnectionInfo connection)
    {
        var freeSql = GetFreeSqlInstance("Default");
        connection.Id = connection.Id;
        connection.DatabaseType = _aesEncryptionService.Encrypt(connection.DatabaseType ?? string.Empty);
        connection.ServerAddress = _aesEncryptionService.Encrypt(connection.ServerAddress ?? string.Empty);
        connection.DatabaseName = _aesEncryptionService.Encrypt(connection.DatabaseName ?? string.Empty);
        connection.Username = _aesEncryptionService.Encrypt(connection.Username ?? string.Empty);
        connection.Password = _aesEncryptionService.Encrypt(connection.Password ?? string.Empty);
        freeSql.CodeFirst.SyncStructure<ConnectionInfo>();
        await freeSql.InsertOrUpdate<ConnectionInfo>().SetSource(connection).ExecuteAffrowsAsync();
    }

    public async Task UpdateConnectionAsync(string id, ConnectionInfo connection)
    {
        var freeSql = GetFreeSqlInstance("Default");
        if (id != connection.Id)
        {
            throw new ArgumentException("连接ID不匹配");
        }

        connection.DatabaseType = _aesEncryptionService.Encrypt(connection.DatabaseType ?? string.Empty);
        connection.ServerAddress = _aesEncryptionService.Encrypt(connection.ServerAddress ?? string.Empty);
        connection.DatabaseName = _aesEncryptionService.Encrypt(connection.DatabaseName ?? string.Empty);
        connection.Username = _aesEncryptionService.Encrypt(connection.Username ?? string.Empty);
        connection.Password = _aesEncryptionService.Encrypt(connection.Password ?? string.Empty);

        await freeSql.Update<ConnectionInfo>().SetSource(connection).ExecuteAffrowsAsync();
    }

    public async Task<bool> DeleteConnectionAsync(string id)
    {
        var freeSql = GetFreeSqlInstance("Default");
        var affectedRows = await freeSql.Delete<ConnectionInfo>().Where(c => c.Id == id).ExecuteAffrowsAsync();
        return affectedRows > 0;
    }
}
