using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_SMTMACHINELOCS", DisableSyncStructure = true)]
	public partial class BIZSMTMACHINELOCS {

		[JsonProperty, Column(Name = "BIZ_SMTMACHINELOCSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZSMTMACHINELOCSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SMTMACHINECODEID", DbType = "CHAR(16 BYTE)")]
		public string BIZSMTMACHINECODEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SMTMACHINELOCID", DbType = "CHAR(16 BYTE)")]
		public string BIZSMTMACHINELOCID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SMTMACHINELOCSNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZSMTMACHINELOCSNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
