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
	public partial class CLFTRACELOG {

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CLFID { get; set; }

		[JsonProperty]
		public DateTime? LOGDATE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string LOGMESSAGE { get; set; }

	}

}
