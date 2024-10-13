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
	public partial class CIOMACHINEENDPOINTS {

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ENDPOINTNAME { get; set; }

		[JsonProperty]
		public uint? ENDPOINTTYPE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTUPDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string LOCALBINDING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string LOCALBINDINGCONFIG { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string LOCALURI { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MACHINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string REMOTEBINDING { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string REMOTEBINDINGCONFIG { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string REMOTEURI { get; set; }

	}

}
