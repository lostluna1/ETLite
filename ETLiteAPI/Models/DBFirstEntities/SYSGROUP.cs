using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_GROUP", DisableSyncStructure = true)]
	public partial class SYSGROUP {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string GROUPID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ADDRESS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty]
		public int? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 200, IsNullable = false)]
		public string GROUPNAME { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PHONENO { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

	}

}
