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
	public partial class DBCATEGORIES {

		[JsonProperty, Column(IsPrimary = true)]
		public uint DBCATEGORYID { get; set; }

		[JsonProperty]
		public uint? DATASOURCENAMEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DBCATEGORYDESCRIPTION { get; set; }

		[JsonProperty]
		public bool? EXPOSEDTOSTORAGE { get; set; }

		[JsonProperty]
		public bool? EXPOSEDTOTABLE { get; set; }

		[JsonProperty]
		public bool? PROPAGATE { get; set; }

	}

}
