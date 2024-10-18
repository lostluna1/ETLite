using ETLiteAPI.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

namespace ETLiteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ConnectionsController : ControllerBase
{
    private readonly IFreeSql _freeSql;
    private readonly IDataProtector _protector;

    public ConnectionsController(IDictionary<string, IFreeSql> freeSqlDict, IDataProtectionProvider provider)
    {
        // 从字典中获取默认的 IFreeSql 实例
        _freeSql = freeSqlDict["Default"];
        _protector = provider.CreateProtector("ConnectionInfoProtector");
    }

    [HttpGet]
    public async Task<IActionResult> GetConnections()
    {
        var connections = await _freeSql.Select<ConnectionInfo>().ToListAsync();
        foreach (var connection in connections)
        {
            connection.Id = connection.Id;
            connection.DatabaseType = _protector.Unprotect(connection.DatabaseType);
            connection.ServerAddress = _protector.Unprotect(connection.ServerAddress);
            connection.DatabaseName = _protector.Unprotect(connection.DatabaseName);
            connection.Username = _protector.Unprotect(connection.Username);
            connection.Password = _protector.Unprotect(connection.Password);
        }
        return Ok(connections);
    }

    [HttpPost]
    public async Task<IActionResult> SaveConnection([FromBody] ConnectionInfo connection)
    {
        connection.Id = connection.Id;
        connection.DatabaseType = _protector.Protect(connection.DatabaseType);
        connection.ServerAddress = _protector.Protect(connection.ServerAddress);
        connection.DatabaseName = _protector.Protect(connection.DatabaseName);
        connection.Username = _protector.Protect(connection.Username);
        connection.Password = _protector.Protect(connection.Password);
        _freeSql.CodeFirst.SyncStructure<ConnectionInfo>();
        await _freeSql.InsertOrUpdate<ConnectionInfo>().SetSource(connection).ExecuteAffrowsAsync();
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateConnection(string id, [FromBody] ConnectionInfo connection)
    {
        if (id != connection.Id)
        {
            return BadRequest("连接ID不匹配");
        }

        connection.DatabaseType = _protector.Protect(connection.DatabaseType);
        connection.ServerAddress = _protector.Protect(connection.ServerAddress);
        connection.DatabaseName = _protector.Protect(connection.DatabaseName);
        connection.Username = _protector.Protect(connection.Username);
        connection.Password = _protector.Protect(connection.Password);

        await _freeSql.Update<ConnectionInfo>().SetSource(connection).ExecuteAffrowsAsync();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteConnection(string id)
    {
        var affectedRows = await _freeSql.Delete<ConnectionInfo>().Where(c => c.Id == id).ExecuteAffrowsAsync();
        if (affectedRows > 0)
        {
            return NoContent();
        }
        return NotFound();
    }
}
