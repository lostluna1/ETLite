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
	public partial class DBCOLUMNS {

		[JsonProperty]
		public bool? ALLOWSYSTEMTODELETE { get; set; }

		[JsonProperty]
		public bool? ALLOWSYSTEMTOUPDATE { get; set; }

		[JsonProperty]
		public uint? ASSOCIATEDCOLUMNID { get; set; }

		[JsonProperty]
		public bool? CASESENSITIVE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string COLUMNDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string COLUMNNAME { get; set; }

		[JsonProperty]
		public uint? COLUMNSEQUENCE { get; set; }

		[JsonProperty]
		public uint? COLUMNUSAGEID { get; set; }

		[JsonProperty]
		public uint? DBCOLUMNID { get; set; }

		[JsonProperty]
		public uint? DBTABLEID { get; set; }

		[JsonProperty]
		public bool? FORCETOLOWER { get; set; }

		[JsonProperty]
		public bool? FORCETOUPPER { get; set; }

		[JsonProperty]
		public uint? PRECISIONVALUE { get; set; }

		[JsonProperty]
		public uint? PRIMARYKEYSEQUENCE { get; set; }

		[JsonProperty]
		public uint? SCALE { get; set; }

		[JsonProperty]
		public uint? SQLTYPEVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
