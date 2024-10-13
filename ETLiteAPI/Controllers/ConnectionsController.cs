// Controllers/ConnectionsController.cs

using ETLiteAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

namespace ETLiteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConnectionsController : ControllerBase
{
    private readonly string _appSettingsPath;

    public ConnectionsController()
    {
        _appSettingsPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
    }

    [HttpGet]
    public IActionResult GetConnections()
    {
        if (System.IO.File.Exists(_appSettingsPath))
        {
            var appSettingsJson = System.IO.File.ReadAllText(_appSettingsPath);
            var appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();

            if (appSettings.ContainsKey("Connections"))
            {
                var connections = JsonSerializer.Deserialize<Dictionary<string, ConnectionInfo>>(appSettings["Connections"].GetRawText()) ?? new Dictionary<string, ConnectionInfo>();
                return Ok(connections);
            }
        }
        return Ok(new Dictionary<string, ConnectionInfo>());
    }

    [HttpPost]
    public IActionResult SaveConnection([FromBody] ConnectionInfo connection)
    {
        var appSettings = new Dictionary<string, JsonElement>();

        if (System.IO.File.Exists(_appSettingsPath))
        {
            var appSettingsJson = System.IO.File.ReadAllText(_appSettingsPath);
            appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();
        }

        var connections = new Dictionary<string, ConnectionInfo>();

        if (appSettings.ContainsKey("Connections"))
        {
            connections = JsonSerializer.Deserialize<Dictionary<string, ConnectionInfo>>(appSettings["Connections"].GetRawText()) ?? new Dictionary<string, ConnectionInfo>();
        }

        if (!string.IsNullOrEmpty(connection.ConnectionName))
        {
            connections[connection.ConnectionName] = connection;
        }

        appSettings["Connections"] = JsonSerializer.SerializeToElement(connections);

        var updatedAppSettingsJson = JsonSerializer.Serialize(appSettings, new JsonSerializerOptions { WriteIndented = true });
        System.IO.File.WriteAllText(_appSettingsPath, updatedAppSettingsJson);

        return NoContent();
    }


    [HttpPut("{connectionName}")]
    public IActionResult UpdateConnection(string connectionName, [FromBody] ConnectionInfo connection)
    {
        if (connectionName != connection.ConnectionName)
        {
            return BadRequest("连接名称不匹配");
        }

        if (System.IO.File.Exists(_appSettingsPath))
        {
            var appSettingsJson = System.IO.File.ReadAllText(_appSettingsPath);
            var appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();

            if (appSettings.ContainsKey("Connections"))
            {
                var connections = JsonSerializer.Deserialize<Dictionary<string, ConnectionInfo>>(appSettings["Connections"].GetRawText()) ?? new Dictionary<string, ConnectionInfo>();

                if (connections.ContainsKey(connectionName))
                {
                    connections[connectionName] = connection;

                    appSettings["Connections"] = JsonSerializer.SerializeToElement(connections);

                    var updatedAppSettingsJson = JsonSerializer.Serialize(appSettings, new JsonSerializerOptions { WriteIndented = true });
                    System.IO.File.WriteAllText(_appSettingsPath, updatedAppSettingsJson);

                    return NoContent();
                }
                else
                {
                    return NotFound("连接未找到");
                }
            }
        }

        return NotFound("配置文件未找到");
    }
    [HttpDelete("{connectionName}")]
    public IActionResult DeleteConnection(string connectionName)
    {
        if (System.IO.File.Exists(_appSettingsPath))
        {
            var appSettingsJson = System.IO.File.ReadAllText(_appSettingsPath);
            var appSettings = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(appSettingsJson) ?? new Dictionary<string, JsonElement>();

            if (appSettings.ContainsKey("Connections"))
            {
                var connections = JsonSerializer.Deserialize<Dictionary<string, ConnectionInfo>>(appSettings["Connections"].GetRawText()) ?? new Dictionary<string, ConnectionInfo>();

                if (connections.Remove(connectionName))
                {
                    appSettings["Connections"] = JsonSerializer.SerializeToElement(connections);

                    var updatedAppSettingsJson = JsonSerializer.Serialize(appSettings, new JsonSerializerOptions { WriteIndented = true });
                    System.IO.File.WriteAllText(_appSettingsPath, updatedAppSettingsJson);

                    return NoContent();
                }
            }
        }

        return NotFound();
    }
}
