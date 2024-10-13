using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_ROLEFIELDS", DisableSyncStructure = true)]
	public partial class SYSROLEFIELDS {

		[JsonProperty, Column(IsPrimary = true)]
		public int ROLEFIELDSID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string AUTHFIELDS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 36)]
		public string DBSERVICEID { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int? ROLEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string TABLENAME { get; set; }

	}

}
