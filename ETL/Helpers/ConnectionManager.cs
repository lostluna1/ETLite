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
        _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7220/") }; // Ìæ»»ÎªÄãµÄAPIµØÖ·
        SavedConnections = new ObservableCollection<ConnectionInfo>();
        _ = LoadSavedConnections();
    }

    //public void SetCurrentConnection(ConnectionInfo connection)
    //{
    //    CurrentConnection = connection;
    //}

    public void AddConnection(ConnectionInfo connection)
    {
        if (!SavedConnections.Contains(connection))
        {
        }
    }

    public void RemoveConnection(ConnectionInfo connection)
    {
        
    }
    public Task UpdateConnection(ConnectionInfo connection)
    {
        var existingConnection = SavedConnections.FirstOrDefault(c => c.ConnectionName == connection.ConnectionName);
        if (existingConnection != null)
        {
            existingConnection.DatabaseType = connection.DatabaseType;
            existingConnection.ServerAddress = connection.ServerAddress;
            existingConnection.DatabaseName = connection.DatabaseName;
            existingConnection.Username = connection.Username;
            existingConnection.Password = connection.Password;
            existingConnection.Id = connection.Id;

        }

        return Task.CompletedTask;
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

    
}
