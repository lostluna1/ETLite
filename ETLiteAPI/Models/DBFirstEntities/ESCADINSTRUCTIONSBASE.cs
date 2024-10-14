using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESCADINSTRUCTIONSBASE {

		[JsonProperty, Column(Name = "ES_CADINSTRUCTIONSBASEID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESCADINSTRUCTIONSBASEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_CADINSTRUCTIONSNAME", DbType = "VARCHAR2(100 BYTE)")]
		public string ESCADINSTRUCTIONSNAME { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REVOFRCDID { get; set; }

	}

}
