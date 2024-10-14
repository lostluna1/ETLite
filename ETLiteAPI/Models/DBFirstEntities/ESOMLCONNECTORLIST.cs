using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESOMLCONNECTORLIST {

		[JsonProperty, Column(Name = "ES_OMLCONNECTORLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESOMLCONNECTORLISTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_GATEWAY", DbType = "VARCHAR2(512 BYTE)")]
		public string ESGATEWAY { get; set; }

		[JsonProperty, Column(Name = "ES_LOGCIOERRORFILES")]
		public uint? ESLOGCIOERRORFILES { get; set; }

		[JsonProperty, Column(Name = "ES_OMLCONNECTORLISTNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESOMLCONNECTORLISTNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PASSWORD", DbType = "VARCHAR2(128 BYTE)")]
		public string ESPASSWORD { get; set; }

		[JsonProperty, Column(Name = "ES_USERNAME", DbType = "VARCHAR2(255 BYTE)")]
		public string ESUSERNAME { get; set; }

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
