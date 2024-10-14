using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESPRODCLIENTUICONFIGDETAILS {

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGDETAILSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPRODCLIENTUICONFIGDETAILSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGDETAINAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESPRODCLIENTUICONFIGDETAINAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODCLIENTUICONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGLABELNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESPRODCLIENTUICONFIGLABELNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGLABELTEXT", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRODCLIENTUICONFIGLABELTEXT { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESPRODCLIENTUICONFIGNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGSEQUENCE")]
		public uint? ESPRODCLIENTUICONFIGSEQUENCE { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGTYPE")]
		public uint? ESPRODCLIENTUICONFIGTYPE { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGVISIBLE")]
		public uint? ESPRODCLIENTUICONFIGVISIBLE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
