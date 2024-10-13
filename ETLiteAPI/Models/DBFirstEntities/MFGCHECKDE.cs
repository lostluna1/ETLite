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
	public partial class MFGCHECKDE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MFGCHECKDEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_COMPLETEDATE", DbType = "DATE(7)")]
		public DateTime? BIZCOMPLETEDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_MFGCHECKLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZMFGCHECKLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRINCIPALID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRINCIPALID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATANAME { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string DATAVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string IMPROVETTHESITUATION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string MFGCHECKDENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PRODUCTIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REMARK { get; set; }

		[JsonProperty]
		public uint? STATUSDETERMINATION { get; set; }

	}

}
