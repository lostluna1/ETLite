using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSROLE {

		[JsonProperty, Column(Name = "ROLE_ID", IsPrimary = true)]
		public int ROLEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DATAUTH { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DBSERVICEID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DELETEBY { get; set; }

		[JsonProperty, Column(Name = "DEPT_ID")]
		public int? DEPTID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DEPTNAME { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty]
		public int PARENTID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ROLENAME { get; set; }

	}

}
