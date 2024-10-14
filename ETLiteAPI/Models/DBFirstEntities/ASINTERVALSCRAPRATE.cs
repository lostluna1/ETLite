using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASINTERVALSCRAPRATE {

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string BU { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string INTERVAFROM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string INTERVATO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string PARTNO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SCRAPRATE { get; set; }

	}

}
