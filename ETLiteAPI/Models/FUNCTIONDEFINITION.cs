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
	public partial class FUNCTIONDEFINITION {

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? FEATUREID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OCXGUID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string OCXVERSION { get; set; }

		[JsonProperty]
		public uint? SIGNATUREID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
