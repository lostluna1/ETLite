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
	public partial class QUERYPARMS {

		[JsonProperty]
		public uint? CPPDATATYPEID { get; set; }

		[JsonProperty]
		public bool? ISINPUTPARM { get; set; }

		[JsonProperty]
		public bool? ISLIST { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty]
		public uint? QUERYDEFID { get; set; }

		[JsonProperty]
		public uint? QUERYPARMID { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
