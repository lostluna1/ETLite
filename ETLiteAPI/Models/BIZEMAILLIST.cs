using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_EMAILLIST", DisableSyncStructure = true)]
	public partial class BIZEMAILLIST {

		[JsonProperty, Column(Name = "BIZ_EMAILLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEMAILLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EMAILLISTNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEMAILLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EMAILURL", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZEMAILURL { get; set; }

		[JsonProperty, Column(Name = "BIZ_REMARK", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZREMARK { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLID { get; set; }

	}

}
