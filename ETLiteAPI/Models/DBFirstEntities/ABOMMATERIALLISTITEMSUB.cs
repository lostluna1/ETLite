using FreeSql.DataAnnotations;
using Newtonsoft.Json;

namespace ETLiteAPI.Models;

[JsonObject(MemberSerialization.OptIn), Table(Name = "A_BOMMATERIALLISTITEMSUB", DisableSyncStructure = true)]
public partial class ABOMMATERIALLISTITEMSUB
{

    [JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
    public string BOMMATERIALLISTITEMID
    {
        get; set;
    }

    [JsonProperty, Column(IsPrimary = true)]
    public uint FIELDID
    {
        get; set;
    }

    [JsonProperty, Column(IsPrimary = true)]
    public uint SEQUENCE
    {
        get; set;
    }

    [JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
    public string SUBSTITUTESBASEID
    {
        get; set;
    }

    [JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
    public string SUBSTITUTESID
    {
        get; set;
    }

}
