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
	public partial class USERCODEGROUPENTRIES {

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string INSTANCEID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ENTRIESID { get; set; }

	}

}
