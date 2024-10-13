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
	public partial class NOTIFICATIONSERVERS {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string HOSTNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string SERVERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string SERVERTYPE { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
