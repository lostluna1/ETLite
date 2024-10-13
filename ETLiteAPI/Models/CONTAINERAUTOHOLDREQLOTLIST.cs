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
	public partial class CONTAINERAUTOHOLDREQLOTLIST {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERAUTOHOLDREQID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOTLIST { get; set; }

	}

}
