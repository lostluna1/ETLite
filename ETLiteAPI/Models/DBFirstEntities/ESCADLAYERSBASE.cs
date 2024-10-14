using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESCADLAYERSBASE {

		[JsonProperty, Column(Name = "ES_CADLAYERSBASEID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESCADLAYERSBASEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_CADLAYERSNAME", DbType = "VARCHAR2(100 BYTE)")]
		public string ESCADLAYERSNAME { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REVOFRCDID { get; set; }

	}

}
