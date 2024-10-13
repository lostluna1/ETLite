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
	public partial class CDOLABELS {

		[JsonProperty, Column(IsPrimary = true)]
		public uint CDOLABELID { get; set; }

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty]
		public uint? LABELID { get; set; }

		[JsonProperty]
		public uint? LABELTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
