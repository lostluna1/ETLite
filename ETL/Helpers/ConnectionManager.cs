// ConnectionManager.cs

using System.Net.Http.Json;
using ETL.Models;
namespace ETL.Helpers;

public class ConnectionManager
{
    private static readonly Lazy<ConnectionManager> _instance = new(() => new ConnectionManager());
    private readonly HttpClient _httpClient;

    public static ConnectionManager Instance => _instance.Value;

    public ObservableCollection<ConnectionInfo> SavedConnections
    {
        get; private set;
    }
    public ConnectionInfo? CurrentConnection
    {
        get; private set;
    }

    private ConnectionManager()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7220/") }; // 替换为你的API地址
        SavedConnections = new ObservableCollection<ConnectionInfo>();
        LoadSavedConnections();
    }

    public void SetCurrentConnection(ConnectionInfo connection)
    {
        CurrentConnection = connection;
    }

    public async void AddConnection(ConnectionInfo connection)
    {
        if (!SavedConnections.Contains(connection))
        {
            SavedConnections.Add(connection);
            await SaveConnectionToFile(connection);
        }
    }

    private async Task SaveConnectionToFile(ConnectionInfo connection)
    {
        var response = await _httpClient.PostAsJsonAsync("api/connections", connection);
        response.EnsureSuccessStatusCode();
    }

    public void RemoveConnection(ConnectionInfo connection)
    {
        if (SavedConnections.Contains(connection))
        {
            SavedConnections.Remove(connection);
            SaveConnectionsToFile();
        }
    }
    public async Task UpdateConnection(ConnectionInfo connection)
    {
        var existingConnection = SavedConnections.FirstOrDefault(c => c.ConnectionName == connection.ConnectionName);
        if (existingConnection != null)
        {
            existingConnection.DatabaseType = connection.DatabaseType;
            existingConnection.ServerAddress = connection.ServerAddress;
            existingConnection.DatabaseName = connection.DatabaseName;
            existingConnection.Username = connection.Username;
            existingConnection.Password = connection.Password;

            await UpdateConnectionToFile(connection);
        }
    }

    private async Task UpdateConnectionToFile(ConnectionInfo connection)
    {
        var response = await _httpClient.PutAsJsonAsync($"api/connections/{connection.ConnectionName}", connection);
        response.EnsureSuccessStatusCode();
    }
    private async Task LoadSavedConnections()
    {
        var response = await _httpClient.GetAsync("api/connections");
        if (response.IsSuccessStatusCode)
        {
            var connections = await response.Content.ReadFromJsonAsync<Dictionary<string, ConnectionInfo>>();
            if (connections != null)
            {
                foreach (var connection in connections.Values)
                {
                    SavedConnections.Add(connection);
                }
            }
        }
    }

    private void SaveConnectionsToFile()
    {
        var appSettingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        var appSettings = new Dictionary<string, JsonElement>();

        if (File.Exists(appSettingsPath))
        {
            var appSettingsJson = File.ReadAllText(appSettingsPath);
            appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();
        }

        var connections = SavedConnections
            .Where(c => !string.IsNullOrEmpty(c.ConnectionName))
            .ToDictionary(c => c.ConnectionName!, c => c); // 使用非空断言操作符

        appSettings["Connections"] = JsonSerializer.SerializeToElement(connections);

        var updatedAppSettingsJson = JsonSerializer.Serialize(appSettings, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(appSettingsPath, updatedAppSettingsJson);
    }
}
