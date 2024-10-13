using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_EQUIPBINDTASKBIZ_TOOLLIST", DisableSyncStructure = true)]
	public partial class BIZEQUIPBINDTASKBIZTOOLLIST {

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTASKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEQUIPBINDTASKID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOOLLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZTOOLLISTID { get; set; }

	}

}
