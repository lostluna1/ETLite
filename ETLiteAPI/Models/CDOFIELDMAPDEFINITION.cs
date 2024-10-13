using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class CDOFIELDMAPDEFINITION {

		[JsonProperty]
		public bool? ACCUMULATE { get; set; }

		[JsonProperty]
		public bool? CARRYFORWARD { get; set; }

		[JsonProperty]
		public uint? CDOFIELDMAPID { get; set; }

		[JsonProperty]
		public uint? CDOMAPID { get; set; }

		[JsonProperty]
		public bool? ISDISABLED { get; set; }

		[JsonProperty]
		public uint? SOURCECDOFIELDID { get; set; }

		[JsonProperty]
		public uint? TARGETCDOFIELDID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
