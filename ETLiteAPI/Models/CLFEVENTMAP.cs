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
	public partial class CLFEVENTMAP {

		[JsonProperty]
		public uint? CALLERID { get; set; }

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty]
		public uint? CLFEVENTID { get; set; }

		[JsonProperty]
		public uint? CLFEVENTMAPID { get; set; }

		[JsonProperty]
		public uint? CLFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? FEATUREID { get; set; }

		[JsonProperty]
		public bool? ISHIDDEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty]
		public uint? PERMISSIONMASK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
