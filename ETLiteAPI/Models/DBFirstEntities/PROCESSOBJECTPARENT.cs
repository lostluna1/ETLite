using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSOBJECTPARENT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNER { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PARENTTYPE { get; set; }

		[JsonProperty]
		public uint? STAGE { get; set; }

	}

}
