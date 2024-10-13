using System.Reflection.Emit;
using System.Reflection;
using ETLiteAPI.Models;
using ETLiteAPI.Models.DBFirstEntities;
using FreeSql;
using FreeSql.DatabaseModel;
using FreeSql.Internal.Model;
using Microsoft.Extensions.Logging;
using ConnectionInfo = ETLiteAPI.Models.ConnectionInfo;

namespace ETLiteAPI.Services;
public class DataSyncService : IDataSyncService
{
    private readonly IConfiguration _configuration;
    private readonly ILogger<DataSyncService> _logger;

    public DataSyncService(IConfiguration configuration, ILogger<DataSyncService> logger)
    {
        _configuration = configuration;
        _logger = logger;
    }
    public dynamic SyncData<T>(ConnectionInfo sourceInfo, ConnectionInfo targetInfo, string sql) where T : class, new()
    {
        var sourceConnectionString = BuildConnectionString(sourceInfo);
        var targetConnectionString = BuildConnectionString(targetInfo);

        var sourceDb = new FreeSqlBuilder()
            .UseConnectionString(GetDataType(sourceInfo.DatabaseType), sourceConnectionString)
            .Build();

        var targetDb = new FreeSqlBuilder()
            .UseConnectionString(GetDataType(targetInfo.DatabaseType), targetConnectionString)
            .Build();

        // 从源数据库读取数据
        var sourceData = sourceDb.Select<T>().WithSql(sql).ToList();

        // 同步目标数据库中的表结构
        targetDb.CodeFirst.IsAutoSyncStructure = true; // 启用自动同步
        targetDb.CodeFirst.SyncStructure<T>();

        // 清空目标数据库中的表
        targetDb.Delete<T>().Where("1=1").ExecuteAffrows();

        // 将数据插入到目标数据库
        targetDb.Insert<T>(sourceData).ExecuteAffrows();

        return null;
    }


    private object ConvertToEntity(Dictionary<string, object> row, DbTableInfo tableInfo)
    {
        var entityType = CreateDynamicType(tableInfo);
        var entity = Activator.CreateInstance(entityType);

        foreach (var kvp in row)
        {
            var property = entityType.GetProperty(kvp.Key);
            if (property != null)
            {
                var value = kvp.Value == DBNull.Value ? null : Convert.ChangeType(kvp.Value, property.PropertyType);
                property.SetValue(entity, value);
            }
        }

        return entity;
    }


    private Type CreateDynamicType(DbTableInfo tableInfo)
    {
        var typeBuilder = GetTypeBuilder(tableInfo.Name);

        foreach (var column in tableInfo.Columns)
        {
            CreateProperty(typeBuilder, column.Name, column.CsType);
        }

        return typeBuilder.CreateType();
    }

    private TypeBuilder GetTypeBuilder(string typeName)
    {
        var assemblyName = new AssemblyName(typeName);
        var assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);
        var moduleBuilder = assemblyBuilder.DefineDynamicModule("MainModule");
        var typeBuilder = moduleBuilder.DefineType(typeName, TypeAttributes.Public | TypeAttributes.Class);

        return typeBuilder;
    }

    private void CreateProperty(TypeBuilder typeBuilder, string propertyName, Type propertyType)
    {
        var fieldBuilder = typeBuilder.DefineField("_" + propertyName, propertyType, FieldAttributes.Private);
        var propertyBuilder = typeBuilder.DefineProperty(propertyName, PropertyAttributes.HasDefault, propertyType, null);

        var getMethodBuilder = typeBuilder.DefineMethod("get_" + propertyName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, propertyType, Type.EmptyTypes);
        var getIL = getMethodBuilder.GetILGenerator();
        getIL.Emit(OpCodes.Ldarg_0);
        getIL.Emit(OpCodes.Ldfld, fieldBuilder);
        getIL.Emit(OpCodes.Ret);

        var setMethodBuilder = typeBuilder.DefineMethod("set_" + propertyName, MethodAttributes.Public | MethodAttributes.SpecialName | MethodAttributes.HideBySig, null, new[] { propertyType });
        var setIL = setMethodBuilder.GetILGenerator();
        setIL.Emit(OpCodes.Ldarg_0);
        setIL.Emit(OpCodes.Ldarg_1);
        setIL.Emit(OpCodes.Stfld, fieldBuilder);
        setIL.Emit(OpCodes.Ret);

        propertyBuilder.SetGetMethod(getMethodBuilder);
        propertyBuilder.SetSetMethod(setMethodBuilder);
    }






    private string BuildConnectionString(ConnectionInfo info)
    {
        return info.DatabaseType switch
        {
            "MySQL" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "PostgreSQL" => $"Host={info.ServerAddress};Database={info.DatabaseName};Username={info.Username};Password={info.Password};",
            "SQLServer" => $"Server={info.ServerAddress};Database={info.DatabaseName};User Id={info.Username};Password={info.Password};",
            "Oracle" => $"User Id={info.Username};Password={info.Password};Data Source={info.ServerAddress}/{info.DatabaseName};",
            _ => throw new NotSupportedException($"不支持的数据库类型: {info.DatabaseType}")
        };
    }

    private DataType GetDataType(string? databaseType)
    {
        return databaseType switch
        {
            "MySQL" => DataType.MySql,
            "PostgreSQL" => DataType.PostgreSQL,
            "SQLServer" => DataType.SqlServer,
            "Oracle" => DataType.Oracle,
            _ => throw new NotSupportedException($"不支持的数据库类型: {databaseType}")
        };
    }
}
