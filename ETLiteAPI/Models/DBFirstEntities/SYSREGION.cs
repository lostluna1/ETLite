using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSREGION {

		[JsonProperty, Column(IsPrimary = true)]
		public int ID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CODE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LAT { get; set; }

		[JsonProperty]
		public int? LEVEL { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LNG { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string MERNAME { get; set; }

		[JsonProperty, Column(StringLength = 40)]
		public string NAME { get; set; }

		[JsonProperty]
		public int? PARENTID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string PINYIN { get; set; }

	}

}
