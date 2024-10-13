using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_LOG", DisableSyncStructure = true)]
	public partial class SYSLOG {

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? BEGINDATE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string BROWSERTYPE { get; set; }

		[JsonProperty]
		public int? ELAPSEDTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string EXCEPTIONINFO { get; set; }

		[JsonProperty]
		public int ID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string LOGTYPE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REQUESTPARAMETER { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string RESPONSEPARAMETER { get; set; }

		[JsonProperty, Column(Name = "ROLE_ID")]
		public int? ROLEID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string SERVICEIP { get; set; }

		[JsonProperty]
		public int? SUCCESS { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string URL { get; set; }

		[JsonProperty, Column(Name = "USER_ID")]
		public int? USERID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string USERIP { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string USERNAME { get; set; }

	}

}
