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
	public partial class CDOMAPDEFINITION {

		[JsonProperty]
		public uint? CDOMAPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty]
		public uint? PARENTCDOMAPID { get; set; }

		[JsonProperty]
		public uint? SOURCECDOID { get; set; }

		[JsonProperty]
		public uint? TARGETCDOID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
