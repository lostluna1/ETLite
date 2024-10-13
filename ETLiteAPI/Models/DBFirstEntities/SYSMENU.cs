using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_MENU", DisableSyncStructure = true)]
	public partial class SYSMENU {

		[JsonProperty, Column(Name = "MENU_ID", IsPrimary = true)]
		public int MENUID { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string AUTH { get; set; }

		[JsonProperty]
		public int? AUTHDATA { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CREATOR { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public sbyte? ENABLE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ICON { get; set; }

		[JsonProperty]
		public int? LINKTYPE { get; set; }

		[JsonProperty, Column(StringLength = 50, IsNullable = false)]
		public string MENUNAME { get; set; }

		[JsonProperty]
		public int? MENUTYPE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MODIFIER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MODIFYDATE { get; set; }

		[JsonProperty]
		public int? ORDERNO { get; set; }

		[JsonProperty]
		public int PARENTID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string TABLENAME { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string URL { get; set; }

	}

}
