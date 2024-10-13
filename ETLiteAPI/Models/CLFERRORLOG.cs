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
	public partial class CLFERRORLOG {

		[JsonProperty, Column(DbType = "CLOB")]
		public string CLFPKG { get; set; }

		[JsonProperty]
		public DateTime? LOGDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string LOGMESSAGE { get; set; }

	}

}
