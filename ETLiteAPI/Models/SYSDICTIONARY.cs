using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_DICTIONARY", DisableSyncStructure = true)]
	public partial class SYSDICTIONARY {

		[JsonProperty, Column(Name = "DIC_ID", IsPrimary = true)]
		public int DICID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string CONFIG { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBSERVER { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DBSQL { get; set; }

		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string DICNAME { get; set; }

		[JsonProperty, Column(StringLength = 100, IsNullable = false)]
		public string DICNO { get; set; }

		[JsonProperty]
		public sbyte ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty]
		public int PARENTID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

	}

}
