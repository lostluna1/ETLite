using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class POWERONDET {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string POWERONDETID { get; set; }

		[JsonProperty]
		public uint? ACTIVE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_POWERONINSPECTIONID", DbType = "CHAR(16 BYTE)")]
		public string BIZPOWERONINSPECTIONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_USAGE", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZUSAGE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DAILYINSPECTSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLIFETIMEUPDATED { get; set; }

		[JsonProperty]
		public uint? ISMAINRESOURCE { get; set; }

		[JsonProperty]
		public uint? ISVERIFYDAILYINSPECT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string POWERONDETNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPLACEEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPLACETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLID { get; set; }

	}

}
