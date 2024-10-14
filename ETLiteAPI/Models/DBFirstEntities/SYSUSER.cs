using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSUSER {

		[JsonProperty, Column(Name = "USER_ID", IsPrimary = true)]
		public int USERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DEPTIDS { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string EMAIL { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty]
		public int? GENDER { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string HEADIMAGEURL { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTLOGINDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTMODIFYPWDDATE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty, Column(StringLength = 11)]
		public string PHONENO { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string REMARK { get; set; }

		[JsonProperty, Column(Name = "ROLE_ID")]
		public int? ROLEID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ROLEIDS { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string TOKEN { get; set; }

		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string USERNAME { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string USERPWD { get; set; }

		[JsonProperty, Column(StringLength = 200, IsNullable = false)]
		public string USERTRUENAME { get; set; }

	}

}
