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
	public partial class QUERYTEXT {

		[JsonProperty]
		public uint? DBTYPEID { get; set; }

		[JsonProperty]
		public uint? QUERYDEFID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string QUERYTEXT { get; set; }

		[JsonProperty]
		public uint? QUERYTEXTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
