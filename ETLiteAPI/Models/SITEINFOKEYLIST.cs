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
	public partial class SITEINFOKEYLIST {

		[JsonProperty, Column(IsPrimary = true)]
		public uint RECID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string FORGNCOLNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string FORGNTBLNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string KEYLCOLLOCALNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string TABLENAME { get; set; }

	}

}
