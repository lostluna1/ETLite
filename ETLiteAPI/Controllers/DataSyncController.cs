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
        var entityType = GetTypeByName(request.TableName);
        if (entityType == null)
        {
            return BadRequest("Invalid table name.");
        }

        // 使用反射调用泛型方法
        var method = typeof(IDataSyncService).GetMethod("SyncData")?.MakeGenericMethod(entityType);
        method?.Invoke(_dataSyncService, new object[] { request.SourceInfo, request.TargetInfo, request.Sql });

        return Ok();
    }

    private Type GetTypeByName(string typeName)
    {
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (var assembly in assemblies)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.Name == typeName || type.FullName == typeName)
                {
                    return type;
                }
            }
        }
        return null;
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
}
