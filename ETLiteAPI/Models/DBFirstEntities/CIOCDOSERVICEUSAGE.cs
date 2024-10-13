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
	public partial class CIOCDOSERVICEUSAGE {

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CDONAME { get; set; }

		[JsonProperty]
		public uint? ENDPOINTTYPE { get; set; }

	}

}
