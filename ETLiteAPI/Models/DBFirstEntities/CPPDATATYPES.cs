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
	public partial class CPPDATATYPES {

		[JsonProperty, Column(IsPrimary = true)]
		public uint DATATYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string DATATYPEDESCRIPTION { get; set; }

		[JsonProperty]
		public bool? ISCUSTOM { get; set; }

		[JsonProperty]
		public bool? ISFIELDTYPE { get; set; }

		[JsonProperty]
		public bool? ISFUNDAMENTAL { get; set; }

		[JsonProperty]
		public bool? ISNUMERIC { get; set; }

		[JsonProperty]
		public bool? ISPARAMTYPE { get; set; }

		[JsonProperty]
		public bool? ISTRIVIAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string LISTTYPEDEF { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string LISTTYPEDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string TYPEDEF { get; set; }

	}

}
