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
	public partial class TRANSACTIONIDTABLE {

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)", IsPrimary = true, IsNullable = false)]
		public string TRANSIDNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string TRANSIDVALUE { get; set; }

	}

}
