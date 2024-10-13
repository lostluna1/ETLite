// Models/ConnectionInfo.cs

namespace ETLiteAPI.Models;

public class ConnectionInfo
{
    public string? ConnectionName { get; set; }
    public string? DatabaseType { get; set; }
    public string? ServerAddress { get; set; }
    public string? DatabaseName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
}
