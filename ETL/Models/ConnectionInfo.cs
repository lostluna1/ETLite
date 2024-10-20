﻿using CommunityToolkit.Mvvm.ComponentModel;

namespace ETL.Models;

public partial class ConnectionInfo : ObservableValidator
{
    [ObservableProperty]
    private string? connectionName;

    [ObservableProperty]
    public string? id;

    [ObservableProperty]
    private string? databaseType;

    [ObservableProperty]
    private string? serverAddress;

    [ObservableProperty]
    private string? databaseName;

    [ObservableProperty]
    private string? username;

    [ObservableProperty]
    private string? password;

    public override bool Equals(object? obj)
    {
        return obj is ConnectionInfo info &&
                Id == info.Id &&
               ConnectionName == info.ConnectionName &&
               DatabaseType == info.DatabaseType &&
               ServerAddress == info.ServerAddress &&
               DatabaseName == info.DatabaseName &&
               Username == info.Username &&
               Password == info.Password;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, ConnectionName, DatabaseType, ServerAddress, DatabaseName, Username, Password);
    }
}
