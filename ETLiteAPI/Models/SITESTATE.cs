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
	public partial class SITESTATE {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)", IsPrimary = true, IsNullable = false)]
		public string STATEVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string LASTUPDATEPROCESS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATETIME { get; set; }

		[JsonProperty]
		public uint? LICEXPNOTIFICATIONSTATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SITENAME { get; set; }

	}

}
