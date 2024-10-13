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
	public partial class INSTANCEIDCOUNT {

		[JsonProperty, Column(IsPrimary = true)]
		public uint CDODEFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLIENTINSTANCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CSIINSTANCEID { get; set; }

	}

}
