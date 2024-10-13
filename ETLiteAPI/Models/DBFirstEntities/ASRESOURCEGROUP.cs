using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "AS_RESOURCEGROUP", DisableSyncStructure = true)]
	public partial class ASRESOURCEGROUP {

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string EQPGROUP { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string EQPID { get; set; }

	}

}
