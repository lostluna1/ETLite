using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class FORMDESIGNOPTIONS {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string FORMID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string DARAGGEOPTIONS { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string FORMCONFIG { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string FORMFIELDS { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string FORMOPTIONS { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string TABLECONFIG { get; set; }

		[JsonProperty, Column(StringLength = -2, IsNullable = false)]
		public string TITLE { get; set; }

	}

}
