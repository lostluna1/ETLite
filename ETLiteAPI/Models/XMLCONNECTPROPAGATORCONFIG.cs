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
	public partial class XMLCONNECTPROPAGATORCONFIG {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONFIGKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CONFIGVALUE { get; set; }

	}

}
