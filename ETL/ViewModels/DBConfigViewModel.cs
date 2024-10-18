using System.ComponentModel.DataAnnotations;
using System.Text;
using ETL.Helpers;
using ETL.Models;

namespace ETL.ViewModels;

public partial class DBConfigViewModel : ObservableValidator
{

    [Required]
    [ObservableProperty]
    public string? _selectedDatabaseType;

    [Required]
    [ObservableProperty]
    public string? _serverAddress;

    [Required]
    [ObservableProperty]
    public string? _databaseName;
    [ObservableProperty]
    public string? _id;

    [Required]
    [ObservableProperty]
    public string? _username;

    [Required]
    [ObservableProperty]
    public string? _password;

    [ObservableProperty]
    public string? _connectionName;

    [ObservableProperty]
    private ConnectionInfo? _selectedConnection;

    partial void OnSelectedConnectionChanged(ConnectionInfo? value)
    {
        if (value != null)
        {
            SelectedDatabaseType = value.DatabaseType;
            ServerAddress = value.ServerAddress;
            DatabaseName = value.DatabaseName;
            Username = value.Username;
            Password = value.Password;
            ConnectionName = value.ConnectionName;
            Id = value.Id;
        }
    }
    private IFreeSql? _freeSql;

    public XamlRoot? XamlRoot
    {
        get; set;
    }

    public DBConfigViewModel()
    {
        DatabaseTypes = new ObservableCollection<string> { "Oracle", "SQL Server", "MySQL" };
        SavedConnections = new ObservableCollection<ConnectionInfo>();
        _ = LoadSavedConnectionsAsync();
    }

    public ObservableCollection<string> DatabaseTypes
    {
        get;
    }

    public ObservableCollection<ConnectionInfo> SavedConnections
    {
        get;
    }
    private async Task LoadSavedConnectionsAsync()
    {
        using var httpClient = new HttpClient();
        var response = await httpClient.GetAsync("https://localhost:7220/api/connections");

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            var connections = JsonSerializer.Deserialize<List<ConnectionInfo>>(json, options);

            if (connections != null)
            {
                foreach (var connection in connections)
                {
                    SavedConnections.Add(connection);
                }
            }
        }
        else
        {
            Debug.WriteLine("无法获取连接信息");
        }
    }


    [RelayCommand]
    private async Task AddConnectionAsync()
    {
        if (string.IsNullOrEmpty(ConnectionName) || string.IsNullOrEmpty(SelectedDatabaseType) ||
            string.IsNullOrEmpty(ServerAddress) || string.IsNullOrEmpty(DatabaseName) ||
            string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
        {
            Debug.WriteLine("所有字段都是必填的");
            await ShowDialogAsync("保存失败", "所有字段都是必填的");
            return;
        }

        var connectionInfo = new ConnectionInfo
        {
            //Id = Guid.NewGuid().ToString(),
            Id = SelectedConnection?.Id ?? Guid.NewGuid().ToString(),
            ConnectionName = ConnectionName,
            DatabaseType = SelectedDatabaseType,
            ServerAddress = ServerAddress,
            DatabaseName = DatabaseName,
            Username = Username,
            Password = Password
        };

        using var httpClient = new HttpClient();
        var json = JsonSerializer.Serialize(connectionInfo);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            HttpResponseMessage response;
            if (SelectedConnection == null)
            {
                // 新增连接
                response = await httpClient.PostAsync("https://localhost:7220/api/connections", content);
            }
            else
            {
                json = JsonSerializer.Serialize(SelectedConnection);
                // 更新连接
                response = await httpClient.PutAsync($"https://localhost:7220/api/connections/{SelectedConnection.Id}", content);
            }

            //var responseContent = await response.Content.ReadAsStringAsync();
            //Debug.WriteLine($"服务器响应: {responseContent}");

            if (response.IsSuccessStatusCode)
            {
                //var savedConnection = JsonSerializer.Deserialize<ConnectionInfo>(responseContent);

                //if (savedConnection != null)
                //{
                    if (SelectedConnection == null)
                    {
                        Debug.WriteLine("连接信息已保存");
                        await ShowDialogAsync("保存成功", "连接信息已保存");
                        SavedConnections.Add(connectionInfo);
                    }
                    else
                    {
                        Debug.WriteLine("连接信息已更新");
                        await ShowDialogAsync("更新成功", "连接信息已更新");

                        // 更新本地的连接信息
                        var index = SavedConnections.IndexOf(SelectedConnection);
                        if (index >= 0)
                        {
                            SavedConnections[index] = connectionInfo;
                        }
                    }
                //}
            }
            else
            {
                Debug.WriteLine($"操作失败: {response.StatusCode}, {response.ReasonPhrase}");
                await ShowDialogAsync("操作失败", $"无法保存或更新连接信息: {response.ReasonPhrase}");
            }
        }
        catch (JsonException jsonEx)
        {
            Debug.WriteLine($"JSON 反序列化失败: {jsonEx.Message}");
            await ShowDialogAsync("操作失败", $"JSON 反序列化失败: {jsonEx.Message}");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"请求失败: {ex.Message}");
            await ShowDialogAsync("操作失败", $"请求失败: {ex.Message}");
        }
    }







    [RelayCommand]
    void NewConnection()
    {
        SelectedConnection = null;
        SelectedDatabaseType = null;
        ServerAddress = null;
        DatabaseName = null;
        Username = null;
        Password = null;
        ConnectionName = null;
        Id = null;
    }
    [RelayCommand]
    private async Task DeleteConnectionAsync()
    {
        if (SelectedConnection != null)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7220/api/connections/{SelectedConnection.Id}");

            if (response.IsSuccessStatusCode)
            {
                //ConnectionManager.Instance.RemoveConnection(SelectedConnection); // 使用单例
                SavedConnections.Remove(SelectedConnection);
                Debug.WriteLine("连接已删除");
                await ShowDialogAsync("删除成功", "连接已删除");
            }
            else
            {
                Debug.WriteLine("删除失败");
                await ShowDialogAsync("删除失败", "无法删除连接");
            }
        }
    }


    [RelayCommand]
    private async Task ConnectAsync()
    {
        try
        {
            if (string.IsNullOrEmpty(ServerAddress) || string.IsNullOrEmpty(DatabaseName) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                Debug.WriteLine("所有字段都是必填的");
                return;
            }

            switch (SelectedDatabaseType)
            {
                case "Oracle":
                    await ConnectToDatabaseAsync(FreeSql.DataType.Oracle, ServerAddress, DatabaseName, Username, Password);
                    break;
                case "SQL Server":
                    await ConnectToDatabaseAsync(FreeSql.DataType.SqlServer, ServerAddress, DatabaseName, Username, Password);
                    break;
                case "MySQL":
                    await ConnectToDatabaseAsync(FreeSql.DataType.MySql, ServerAddress, DatabaseName, Username, Password);
                    break;
                default:
                    await Task.CompletedTask;
                    Debug.WriteLine("请选择数据库类型");
                    break;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"连接失败: {ex.Message}");
        }
    }

    private async Task ConnectToDatabaseAsync(FreeSql.DataType dbType, string server, string database, string user, string password)
    {
        var connectionString = dbType switch
        {
            FreeSql.DataType.Oracle => $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={server})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={database})));User Id={user};Password={password};Pooling=false;",
            FreeSql.DataType.SqlServer => $"Server={server};Database={database};User Id={user};Password={password};",
            FreeSql.DataType.MySql => $"Server={server};Database={database};User={user};Password={password};",
            _ => throw new NotSupportedException("不支持的数据库类型")
        };

        _freeSql?.Dispose();

        var freeSqlBuilder = new FreeSqlBuilder()
            .UseConnectionString(dbType, connectionString)
            .Build();

        _freeSql = freeSqlBuilder;

        try
        {
            using var connection = _freeSql.Ado.MasterPool.Get();
            if (connection.Value.State == System.Data.ConnectionState.Closed)
            {
                await connection.Value.OpenAsync();
                Debug.WriteLine($"成功连接到{dbType}数据库");
                await ShowDialogAsync("连接成功", $"成功连接到{dbType}数据库");

            }
            else
            {
                Debug.WriteLine("连接已经打开");
                await ShowDialogAsync("连接成功", "成功连接到数据库");
            }
        }
        catch (Exception ex)
        {
            await ShowDialogAsync("连接失败", ex.Message);

            Debug.WriteLine($"Exception: {ex.Message}");
            Debug.WriteLine($"Stack Trace: {ex.StackTrace}");
        }
    }


    private async Task ShowDialogAsync(string title, string content)
    {
        if (XamlRoot == null)
        {
            Debug.WriteLine("XamlRoot 未设置");
            throw new InvalidOperationException("XamlRoot 未设置");
        }

        var dialog = new ContentDialog
        {
            Title = title,
            Content = content,
            CloseButtonText = "确定",
            XamlRoot = XamlRoot
        };

        await dialog.ShowAsync();
    }
}
