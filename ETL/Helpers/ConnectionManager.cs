// ConnectionManager.cs

using ETL.Models;

namespace ETL.Helpers;

public class ConnectionManager
{
    private static readonly Lazy<ConnectionManager> _instance = new(() => new ConnectionManager());

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
        SavedConnections = new ObservableCollection<ConnectionInfo>();
        LoadSavedConnections();
    }

    public void SetCurrentConnection(ConnectionInfo connection)
    {
        CurrentConnection = connection;
    }

    public void AddConnection(ConnectionInfo connection)
    {
        if (!SavedConnections.Contains(connection))
        {
            SavedConnections.Add(connection);
            SaveConnectionsToFile();
        }
    }

    public void RemoveConnection(ConnectionInfo connection)
    {
        if (SavedConnections.Contains(connection))
        {
            SavedConnections.Remove(connection);
            SaveConnectionsToFile();
        }
    }

    private void LoadSavedConnections()
    {
        var appSettingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        if (File.Exists(appSettingsPath))
        {
            var appSettingsJson = File.ReadAllText(appSettingsPath);
            var appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();

            if (appSettings.ContainsKey("Connections"))
            {
                var connections = JsonSerializer.Deserialize<Dictionary<string, ConnectionInfo>>(appSettings["Connections"].GetRawText()) ?? new Dictionary<string, ConnectionInfo>();
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