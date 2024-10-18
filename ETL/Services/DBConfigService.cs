using System.Net.Http;
using System.Text;
using System.Text.Json;
using ETL.Models;
using ETL.Contracts.Services;
namespace ETL.Services;

public class DBConfigService : IDBConfigService
{
    private readonly HttpClient _httpClient;

    public DBConfigService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<ConnectionInfo>> LoadSavedConnectionsAsync()
    {
        var response = await _httpClient.GetAsync("https://localhost:7220/api/connections");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var connections = JsonSerializer.Deserialize<List<ConnectionInfo>>(json, options);
            return connections ?? new List<ConnectionInfo>();
        }
        else
        {
            Debug.WriteLine("�޷���ȡ������Ϣ");
            return new List<ConnectionInfo>();
        }
    }

    public async Task<bool> AddOrUpdateConnectionAsync(ConnectionInfo connectionInfo, bool isNewConnection)
    {
        var json = JsonSerializer.Serialize(connectionInfo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        HttpResponseMessage response;
        if (isNewConnection)
        {
            response = await _httpClient.PostAsync("https://localhost:7220/api/connections", content);
        }
        else
        {
            response = await _httpClient.PutAsync($"https://localhost:7220/api/connections/{connectionInfo.Id}", content);
        }

        return response.IsSuccessStatusCode;
    }

    public async Task<bool> DeleteConnectionAsync(string connectionId)
    {
        var response = await _httpClient.DeleteAsync($"https://localhost:7220/api/connections/{connectionId}");
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> ConnectToDatabaseAsync(FreeSql.DataType dbType, string connectionString)
    {
        var freeSqlBuilder = new FreeSqlBuilder()
            .UseConnectionString(dbType, connectionString)
            .Build();

        try
        {
            using var connection = freeSqlBuilder.Ado.MasterPool.Get();
            if (connection.Value.State == System.Data.ConnectionState.Closed)
            {
                await connection.Value.OpenAsync();
                Debug.WriteLine($"�ɹ����ӵ�{dbType}���ݿ�");
                return true;
            }
            else
            {
                Debug.WriteLine("�����Ѿ���");
                return true;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"����ʧ��: {ex.Message}");
            return false;
        }
    }
}
