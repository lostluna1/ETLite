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
	public partial class SWITCHINGRULEDETAILS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SWITCHINGRULEDETAILSID { get; set; }

		[JsonProperty]
		public uint? ALLOWAUTOMATICSWITCHING { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMAILDISTRIBUTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string EXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMINSPECTIONLEVELID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? LASTCONTAINERSETCOUNT { get; set; }

		[JsonProperty]
		public uint? PASSORFAILCONTAINERCOUNT { get; set; }

		[JsonProperty]
		public uint? REQUIRENOTIFICATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SWITCHINGRULEID { get; set; }

		[JsonProperty]
		public uint? SWITCHINGRULETYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOINSPECTIONLEVELID { get; set; }

	}

}
