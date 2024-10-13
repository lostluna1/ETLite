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
	public partial class CIOROUTERSTATUS {

		[JsonProperty]
		public uint? BROKERCOUNT { get; set; }

		[JsonProperty]
		public uint? CHANNELSOURCECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MACHINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(127 BYTE)")]
		public string TABLENAME { get; set; }

	}

}
