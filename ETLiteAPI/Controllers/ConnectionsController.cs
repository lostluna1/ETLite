using ETLiteAPI.Repositories.Service;
using Microsoft.AspNetCore.Mvc;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

[ApiController]
[Route("api/[controller]")]
public class ConnectionsController : ControllerBase
{
    private readonly IConnectionService _connectionService;

    public ConnectionsController(IConnectionService connectionService)
    {
        _connectionService = connectionService;
    }

    [HttpGet]
    public async Task<IActionResult> GetConnections()
    {
        try
        {
            var connections = await _connectionService.GetConnectionsAsync();
            return Ok(connections);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost]
    public async Task<IActionResult> SaveConnection([FromBody] ConnectionInfo connection)
    {
        await _connectionService.SaveConnectionAsync(connection);
        return NoContent();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateConnection(string id, [FromBody] ConnectionInfo connection)
    {
        try
        {
            await _connectionService.UpdateConnectionAsync(id, connection);
            return NoContent();
        }
        catch (ArgumentException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteConnection(string id)
    {
        var success = await _connectionService.DeleteConnectionAsync(id);
        if (success)
        {
            return NoContent();
        }
        return NotFound();
    }
}
