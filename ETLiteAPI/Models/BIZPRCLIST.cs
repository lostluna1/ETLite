using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_PRCLIST", DisableSyncStructure = true)]
	public partial class BIZPRCLIST {

		[JsonProperty, Column(Name = "BIZ_PRCLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPRCLISTID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COLUMN671090794 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

	}

}
