using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RESOLVEDPERMISSIONS_TEMPV3", DisableSyncStructure = true)]
	public partial class RESOLVEDPERMISSIONSTEMPV3 {

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ORGANIZATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ROLENAME { get; set; }

	}

}
