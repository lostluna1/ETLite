using Microsoft.AspNetCore.Mvc;
using ETLiteAPI.Models;
using ETLiteAPI.Services;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;
using System;
using System.Linq;

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
        _dataSyncService.SyncData(request.SourceInfo, request.TargetInfo, request.TableName, request.Sql, request.PrimaryKeys);
        return Ok();
    }
}



public class SyncRequest
{
    public ConnectionInfo SourceInfo
    {
        get; set;
    }
    public ConnectionInfo TargetInfo
    {
        get; set;
    }
    public string TableName
    {
        get; set;
    }
    public string Sql
    {
        get; set;
    }
    public List<string>? PrimaryKeys
    {
        get; set;
    } // 新增的可选主键列表
}
