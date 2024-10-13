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
	public partial class METAADMIN {

		[JsonProperty, Column(IsPrimary = true)]
		public uint METAID { get; set; }

		[JsonProperty]
		public uint? CLIENTVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string MASTERTAG { get; set; }

		[JsonProperty]
		public uint? MASTERVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string TABLENAME { get; set; }

	}

}
