using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_USERDEPARTMENT", DisableSyncStructure = true)]
	public partial class SYSUSERDEPARTMENT {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 255)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string DEPARTMENTID { get; set; }

		[JsonProperty]
		public int ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 255)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int USERID { get; set; }

	}

}
