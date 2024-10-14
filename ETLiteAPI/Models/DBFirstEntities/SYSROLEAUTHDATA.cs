using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSROLEAUTHDATA {

		[JsonProperty, Column(Name = "AUTH_ID", IsPrimary = true)]
		public int AUTHID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string AUTHVALUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(Name = "DATATYPE_ID")]
		public int? DATATYPEID { get; set; }

		[JsonProperty]
		public int? LEVELID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty, Column(Name = "NODE_ID", StringLength = 50)]
		public string NODEID { get; set; }

		[JsonProperty, Column(Name = "ROLE_ID")]
		public int? ROLEID { get; set; }

		[JsonProperty, Column(Name = "USER_ID")]
		public int? USERID { get; set; }

	}

}
