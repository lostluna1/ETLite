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
	public partial class MSMQMANAGERS {

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)", IsPrimary = true, IsNullable = false)]
		public string HOSTNAME { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint PORTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATETIME { get; set; }

	}

}
