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
	public partial class CLFFUNPARM {

		[JsonProperty]
		public uint? CLFEVENTMAPID { get; set; }

		[JsonProperty]
		public uint? CLFFUNCTIONID { get; set; }

		[JsonProperty]
		public uint? CLFFUNCTIONPARMVALUEID { get; set; }

		[JsonProperty]
		public bool? DYNAMICPARM { get; set; }

		[JsonProperty]
		public uint? FUNCTIONPARMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string VALUEEXPRESSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
