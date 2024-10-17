namespace ETLiteAPI.FreeSqlUtilities;

using FreeSql;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;
public static class Connector
{
    public static string BuildConnectionString(ConnectionInfo info)
    {
        return info.DatabaseType switch
        {
            "MySQL" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "PostgreSQL" => $"Host={info.ServerAddress};Database={info.DatabaseName};Username={info.Username};Password={info.Password};",
            "SQL Server" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "Oracle" => $"User Id={info.Username};Password={info.Password};Data Source={info.ServerAddress}/{info.DatabaseName};",
            _ => throw new NotSupportedException($"不支持的数据库类型: {info.DatabaseType}")
        };
    }

    public static DataType GetDataType(string? databaseType)
    {
        return databaseType switch
        {
            "MySQL" => DataType.MySql,
            "PostgreSQL" => DataType.PostgreSQL,
            "SQL Server" => DataType.SqlServer,
            "Oracle" => DataType.Oracle,
            _ => throw new NotSupportedException($"不支持的数据库类型: {databaseType}")
        };
    }
}
