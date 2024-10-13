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
	public partial class CLFFUNCTIONS {

		[JsonProperty]
		public uint? CLFFUNCTIONID { get; set; }

		[JsonProperty]
		public uint? CLFID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONID { get; set; }

		[JsonProperty]
		public bool? ISACTIVE { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
