using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESDISPLAYOPTIONS {

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESDISPLAYOPTIONSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESDISPLAYOPTIONSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSXML", DbType = "CLOB")]
		public string ESDISPLAYOPTIONSXML { get; set; }

		[JsonProperty, Column(Name = "ES_ISDEFAULT")]
		public uint? ESISDEFAULT { get; set; }

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
