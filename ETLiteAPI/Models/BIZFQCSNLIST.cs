using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_FQCSNLIST", DisableSyncStructure = true)]
	public partial class BIZFQCSNLIST {

		[JsonProperty, Column(Name = "BIZ_FQCSNLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFQCSNLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCINSPECTIONTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZFQCINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCSNLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZFQCSNLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
