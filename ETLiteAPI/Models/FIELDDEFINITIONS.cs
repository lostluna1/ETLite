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
	public partial class FIELDDEFINITIONS {

		[JsonProperty]
		public bool? CASESENSITIVE { get; set; }

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty]
		public uint? CPPDATATYPEID { get; set; }

		[JsonProperty]
		public uint? DATASUBTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string DISPLAYMASK { get; set; }

		[JsonProperty]
		public uint? FIELDDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(37 BYTE)")]
		public string FIELDDEFNAME { get; set; }

		[JsonProperty]
		public bool? FORCETOLOWER { get; set; }

		[JsonProperty]
		public bool? FORCETOUPPER { get; set; }

		[JsonProperty]
		public uint? PRECISIONVALUE { get; set; }

		[JsonProperty]
		public uint? SCALE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
