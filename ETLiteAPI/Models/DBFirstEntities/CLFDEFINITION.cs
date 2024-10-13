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
	public partial class CLFDEFINITION {

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string CLFDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? CLFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string CLFNAME { get; set; }

		[JsonProperty]
		public uint? CLFTYPE { get; set; }

		[JsonProperty]
		public uint? FEATUREID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONID { get; set; }

		[JsonProperty]
		public uint? SOURCECLFID { get; set; }

		[JsonProperty]
		public uint? VISIBILITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
