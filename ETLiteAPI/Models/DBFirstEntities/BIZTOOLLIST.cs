using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_TOOLLIST", DisableSyncStructure = true)]
	public partial class BIZTOOLLIST {

		[JsonProperty, Column(Name = "BIZ_TOOLLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZTOOLLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBINDTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPBINDTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOOLLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZTOOLLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_USAGE")]
		public uint? BIZUSAGE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLID { get; set; }

	}

}
