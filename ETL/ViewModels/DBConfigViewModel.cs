using System.ComponentModel.DataAnnotations;
using ETL.Helpers;
using ETL.Models;

namespace ETL.ViewModels;

public partial class DBConfigViewModel : ObservableValidator
{
    // 删除手动定义的部分方法
    // partial void OnSelectedConnectionChanged(ConnectionInfo? value);

    [Required]
    [ObservableProperty]
    public string? _selectedDatabaseType;

    [Required]
    [ObservableProperty]
    public string? _serverAddress;

    [Required]
    [ObservableProperty]
    public string? _databaseName;

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
        SavedConnections = ConnectionManager.Instance.SavedConnections; // 使用单例
    }

    public ObservableCollection<string> DatabaseTypes
    {
        get;
    }

    public ObservableCollection<ConnectionInfo> SavedConnections
    {
        get;
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
    }
    [RelayCommand]
    private async Task DeleteConnectionAsync()
    {
        if (SelectedConnection != null)
        {
            using var httpClient = new HttpClient();
            var response = await httpClient.DeleteAsync($"https://localhost:7220/api/connections/{SelectedConnection.ConnectionName}");

            if (response.IsSuccessStatusCode)
            {
                ConnectionManager.Instance.RemoveConnection(SelectedConnection); // 使用单例
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
    /*    [RelayCommand]
        private void DeleteConnection()
        {
            if (SelectedConnection != null)
            {
                ConnectionManager.Instance.RemoveConnection(SelectedConnection); // 使用单例
            }
        }*/

    [RelayCommand]
    private async Task SaveAsync()
    {
        if (string.IsNullOrEmpty(ConnectionName))
        {
            Debug.WriteLine("连接名称不能为空");
            await ShowDialogAsync("保存失败", "连接名称不能为空");
            return;
        }

        var connectionInfo = new ConnectionInfo
        {
            ConnectionName = ConnectionName,
            DatabaseType = SelectedDatabaseType,
            ServerAddress = ServerAddress,
            DatabaseName = DatabaseName,
            Username = Username,
            Password = Password
        };

        // 检查连接名称是否已经存在
        var existingConnection = ConnectionManager.Instance.SavedConnections
            .FirstOrDefault(c => c.ConnectionName == ConnectionName);

        if (existingConnection != null)
        {
            // 更新现有连接
            existingConnection.DatabaseType = SelectedDatabaseType;
            existingConnection.ServerAddress = ServerAddress;
            existingConnection.DatabaseName = DatabaseName;
            existingConnection.Username = Username;
            existingConnection.Password = Password;

            Debug.WriteLine("连接信息已更新");
            ConnectionManager.Instance.UpdateConnection(connectionInfo);

            await ShowDialogAsync("更新成功", "连接信息已更新");
        }
        else
        {
            // 新建连接
            ConnectionManager.Instance.AddConnection(connectionInfo);
            Debug.WriteLine("连接信息已保存");
            await ShowDialogAsync("保存成功", "连接信息已保存");
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

                // 设置当前连接
                ConnectionManager.Instance.SetCurrentConnection(new ConnectionInfo
                {
                    ConnectionName = ConnectionName,
                    DatabaseType = SelectedDatabaseType,
                    ServerAddress = ServerAddress,
                    DatabaseName = DatabaseName,
                    Username = Username,
                    Password = Password
                });
            }
            else
            {
                Debug.WriteLine("连接已经打开");
                ConnectionManager.Instance.SetCurrentConnection(new ConnectionInfo
                {
                    ConnectionName = ConnectionName,
                    DatabaseType = SelectedDatabaseType,
                    ServerAddress = ServerAddress,
                    DatabaseName = DatabaseName,
                    Username = Username,
                    Password = Password
                });
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
