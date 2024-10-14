using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSDBSERVICE {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string DBSERVICEID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ADDRESS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string DATABASENAME { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBIPADDRESS { get; set; }

		[JsonProperty, Column(StringLength = 200, IsNullable = false)]
		public string DBSERVICENAME { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string GROUPID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PHONENO { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string PWD { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string USERID { get; set; }

	}

}
