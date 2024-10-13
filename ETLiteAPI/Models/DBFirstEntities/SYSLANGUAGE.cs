using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_LANGUAGE", DisableSyncStructure = true)]
	public partial class SYSLANGUAGE {

		[JsonProperty, Column(StringLength = 200, IsPrimary = true, IsNullable = false)]
		public string DEFAULTKEY { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ARABIC { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty]
		public int? CREATEID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ENGLISH { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string FRENCH { get; set; }

		[JsonProperty]
		public int ID { get; set; }

		[JsonProperty]
		public int? ISPACKAGECONTENT { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? MODIFYID { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODULE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string RUSSIAN { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string SPANISH { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string THAI { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string VIETNAMESE { get; set; }

		[JsonProperty, Column(StringLength = -2, IsNullable = false)]
		public string ZHCN { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string ZHTW { get; set; }

	}

}
