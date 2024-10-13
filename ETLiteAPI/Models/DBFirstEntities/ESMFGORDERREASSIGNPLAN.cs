using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_MFGORDERREASSIGNPLAN", DisableSyncStructure = true)]
	public partial class ESMFGORDERREASSIGNPLAN {

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESMFGORDERREASSIGNPLANID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESMFGORDERREASSIGNPLANNAME { get; set; }

		[JsonProperty, Column(Name = "ES_SETUPACCESSID", DbType = "CHAR(16 BYTE)")]
		public string ESSETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
