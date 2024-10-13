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
	public partial class LICENSEINFO {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTHEARTBEATDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTHEARTBEATDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string LICENSEINFOBLOB { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string OWNER { get; set; }

	}

}
