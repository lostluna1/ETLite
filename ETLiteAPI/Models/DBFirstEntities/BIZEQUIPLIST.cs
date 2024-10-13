using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_EQUIPLIST", DisableSyncStructure = true)]
	public partial class BIZEQUIPLIST {

		[JsonProperty, Column(Name = "BIZ_EQUIPLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEQUIPLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPBORROWTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPBORROWTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZEQUIPLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLID { get; set; }

	}

}
