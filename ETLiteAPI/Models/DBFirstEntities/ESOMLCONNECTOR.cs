using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESOMLCONNECTOR {

		[JsonProperty, Column(Name = "ES_OMLCONNECTORID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESOMLCONNECTORID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_ISACTIVE")]
		public uint? ESISACTIVE { get; set; }

		[JsonProperty, Column(Name = "ES_LINEID", DbType = "CHAR(16 BYTE)")]
		public string ESLINEID { get; set; }

		[JsonProperty, Column(Name = "ES_LOGCIOERRORFILES")]
		public uint? ESLOGCIOERRORFILES { get; set; }

		[JsonProperty, Column(Name = "ES_OMLCONNECTOR", DbType = "VARCHAR2(40 BYTE)")]
		public string ES_OMLCONNECTOR { get; set; }

		[JsonProperty, Column(Name = "ES_OMLCONNECTORLISTID", DbType = "CHAR(16 BYTE)")]
		public string ESOMLCONNECTORLISTID { get; set; }

		[JsonProperty, Column(Name = "ES_OMLCONNECTORNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESOMLCONNECTORNAME { get; set; }

		[JsonProperty, Column(Name = "ES_OMLSERVICEID", DbType = "VARCHAR2(255 BYTE)")]
		public string ESOMLSERVICEID { get; set; }

		[JsonProperty, Column(Name = "ES_USEGATEWAY")]
		public uint? ESUSEGATEWAY { get; set; }

		[JsonProperty, Column(Name = "ES_WEBAPIADAPTERID", DbType = "CHAR(16 BYTE)")]
		public string ESWEBAPIADAPTERID { get; set; }

		[JsonProperty, Column(Name = "ES_WEBAPIADAPTERNAME", DbType = "VARCHAR2(30 BYTE)")]
		public string ESWEBAPIADAPTERNAME { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
