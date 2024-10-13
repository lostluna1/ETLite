using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_ROLEAUTH", DisableSyncStructure = true)]
	public partial class SYSROLEAUTH {

		[JsonProperty, Column(Name = "AUTH_ID")]
		public int AUTHID { get; set; }

		[JsonProperty, Column(StringLength = 2000)]
		public string AUTHVALUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(Name = "MENU_ID")]
		public int MENUID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty, Column(Name = "ROLE_ID")]
		public int? ROLEID { get; set; }

		[JsonProperty, Column(Name = "USER_ID")]
		public int? USERID { get; set; }

	}

}
