using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSPOST {

		[JsonProperty, Column(IsPrimary = true)]
		public int POSTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DEPTCODE { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 200, IsNullable = false)]
		public string POSTNAME { get; set; }

	}

}
