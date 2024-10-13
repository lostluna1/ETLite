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
	public partial class SQLDATATYPES {

		[JsonProperty, Column(IsPrimary = true)]
		public uint SQLTYPEVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string DATATYPEDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string SQLTYPE { get; set; }

	}

}
