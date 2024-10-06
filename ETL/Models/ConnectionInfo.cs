﻿namespace ETL.Models;

public class ConnectionInfo
{
    public string? ConnectionName
    {
        get; set;
    }
    public string? DatabaseType
    {
        get; set;
    }
    public string? ServerAddress
    {
        get; set;
    }
    public string? DatabaseName
    {
        get; set;
    }
    public string? Username
    {
        get; set;
    }
    public string? Password
    {
        get; set;
    }

    public override bool Equals(object? obj)
    {
        return obj is ConnectionInfo info &&
               ConnectionName == info.ConnectionName &&
               DatabaseType == info.DatabaseType &&
               ServerAddress == info.ServerAddress &&
               DatabaseName == info.DatabaseName &&
               Username == info.Username &&
               Password == info.Password;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ConnectionName, DatabaseType, ServerAddress, DatabaseName, Username, Password);
    }
}
