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
	public partial class DBIDENTIFIERHISTORY {

		[JsonProperty, Column(DbType = "DATE(7)", IsPrimary = true)]
		public DateTime ASSIGNMENTTIMESTAMP { get; set; }

		[JsonProperty, Column(DbType = "CHAR(10 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DBIDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SITENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REMOVALTIMESTAMP { get; set; }

	}

}
