using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_CHECKREASONGROUPDEFAULTFOR", DisableSyncStructure = true)]
	public partial class BIZCHECKREASONGROUPDEFAULTFOR {

		[JsonProperty, Column(Name = "BIZ_CHECKREASONGROUPID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZCHECKREASONGROUPID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty]
		public uint? DEFAULTFOROBJECTTYPES { get; set; }

	}

}
