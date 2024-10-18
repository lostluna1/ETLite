using System.ComponentModel.DataAnnotations;
using System.Text;
using ETL.Contracts.Services;
using ETL.Helpers;
using ETL.Models;
using ETL.Services;

namespace ETL.ViewModels;

public partial class DBConfigViewModel : ObservableValidator
{
    private readonly IDBConfigService _dbConfigService;

    public DBConfigViewModel(IDBConfigService dbConfigService)
    {
        _dbConfigService = dbConfigService;
        DatabaseTypes = new ObservableCollection<string> { "Oracle", "SQL Server", "MySQL" };
        SavedConnections = new ObservableCollection<ConnectionInfo>();
        _ = LoadSavedConnectionsAsync();
    }

    [ObservableProperty]
    private XamlRoot? _xamlRoot;

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
        var connections = await _dbConfigService.LoadSavedConnectionsAsync();
        foreach (var connection in connections)
        {
            SavedConnections.Add(connection);
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
            Id = SelectedConnection?.Id ?? Guid.NewGuid().ToString(),
            ConnectionName = ConnectionName,
            DatabaseType = SelectedDatabaseType,
            ServerAddress = ServerAddress,
            DatabaseName = DatabaseName,
            Username = Username,
            Password = Password
        };

        var isNewConnection = SelectedConnection == null;
        var success = await _dbConfigService.AddOrUpdateConnectionAsync(connectionInfo, isNewConnection);

        if (success)
        {
            if (isNewConnection)
            {
                Debug.WriteLine("连接信息已保存");
                await ShowDialogAsync("保存成功", "连接信息已保存");
                SavedConnections.Add(connectionInfo);
            }
            else
            {
                Debug.WriteLine("连接信息已更新");
                await ShowDialogAsync("更新成功", "连接信息已更新");

                var index = SavedConnections.IndexOf(SelectedConnection);
                if (index >= 0)
                {
                    SavedConnections[index] = connectionInfo;
                }
            }
        }
        else
        {
            Debug.WriteLine("操作失败");
            await ShowDialogAsync("操作失败", "无法保存或更新连接信息");
        }
    }

    [RelayCommand]
    private void NewConnection()
    {
        SelectedConnection = null;
        ConnectionName = string.Empty;
        SelectedDatabaseType = string.Empty;
        ServerAddress = string.Empty;
        DatabaseName = string.Empty;
        Username = string.Empty;
        Password = string.Empty;
    }


    [RelayCommand]
    private async Task DeleteConnectionAsync()
    {
        if (SelectedConnection != null)
        {
            var success = await _dbConfigService.DeleteConnectionAsync(SelectedConnection.Id);
            if (success)
            {
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

            var connectionString = SelectedDatabaseType switch
            {
                "Oracle" => $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={ServerAddress})(PORT=1521))(CONNECT_DATA=(SERVICE_NAME={DatabaseName})));User Id={Username};Password={Password};Pooling=false;",
                "SQL Server" => $"Server={ServerAddress};Database={DatabaseName};User Id={Username};Password={Password};",
                "MySQL" => $"Server={ServerAddress};Database={DatabaseName};User={Username};Password={Password};",
                _ => throw new NotSupportedException("不支持的数据库类型")
            };

            var dbType = SelectedDatabaseType switch
            {
                "Oracle" => FreeSql.DataType.Oracle,
                "SQL Server" => FreeSql.DataType.SqlServer,
                "MySQL" => FreeSql.DataType.MySql,
                _ => throw new NotSupportedException("不支持的数据库类型")
            };

            var success = await _dbConfigService.ConnectToDatabaseAsync(dbType, connectionString);
            if (success)
            {
                await ShowDialogAsync("连接成功", $"成功连接到{SelectedDatabaseType}数据库");
            }
            else
            {
                await ShowDialogAsync("连接失败", "无法连接到数据库");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"连接失败: {ex.Message}");
            await ShowDialogAsync("连接失败", ex.Message);
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
