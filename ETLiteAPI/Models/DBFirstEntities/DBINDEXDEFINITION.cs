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
	public partial class DBINDEXDEFINITION {

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DBINDEXDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DBINDEXID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DBINDEXNAME { get; set; }

		[JsonProperty]
		public uint? DBTABLEDEFID { get; set; }

		[JsonProperty]
		public bool? ISDISABLE { get; set; }

		[JsonProperty]
		public bool? ISUNIQUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
