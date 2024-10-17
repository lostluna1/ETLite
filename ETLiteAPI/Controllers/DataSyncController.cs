using Microsoft.AspNetCore.Mvc;

namespace ETLiteAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DataSyncController : ControllerBase
{
    private readonly IDataSyncService _dataSyncService;

    public DataSyncController(IDataSyncService dataSyncService)
    {
        _dataSyncService = dataSyncService;
    }

    [HttpPost("sync")]
    public IActionResult SyncData([FromBody] SyncRequest request)
    {
        var result = _dataSyncService.SyncData(request.SourceConnName, request.TargetConnName, request.TableName, request.Sql, request.PrimaryKeys);

        if (result.Code == 0)
        {
            return Ok(result);
        }
        else
        {
            return StatusCode(500, result); 
        }
    }
}



public class SyncRequest
{
    public required string SourceConnName
    {
        get; set;
    }
    public required string TargetConnName
    {
        get; set;
    }
    public required string TableName
    {
        get; set;
    }
    public required string Sql
    {
        get; set;
    }
    public List<string>? PrimaryKeys
    {
        get; set;
    } // 新增的可选主键列表
}