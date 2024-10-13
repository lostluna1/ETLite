using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_LABELPRINTSETUPBIZ_LABELSE", DisableSyncStructure = true)]
	public partial class BIZLABELPRINTSETUPBIZLABELSE {

		[JsonProperty, Column(Name = "BIZ_LABELPRINTSETUPID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZLABELPRINTSETUPID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABELSETUPLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABELSETUPLISTID { get; set; }

	}

}
