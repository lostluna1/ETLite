using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSPRINTOPTIONS {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string PRINTOPTIONSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string CUSTOMNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DBSERVICE { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string HTML { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string OPTIONS { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string TABLECNNAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string TABLENAME { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string TENANCYID { get; set; }

		[JsonProperty]
		public int? USERID { get; set; }

	}

}
