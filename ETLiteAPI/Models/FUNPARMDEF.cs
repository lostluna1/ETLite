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
	public partial class FUNPARMDEF {

		[JsonProperty]
		public uint? CDODEFID { get; set; }

		[JsonProperty]
		public uint? DATATYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DEFAULTVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string DIRECTION { get; set; }

		[JsonProperty]
		public uint? FUNCTIONID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONPARMID { get; set; }

		[JsonProperty]
		public uint? FUNCTIONPARMUSAGEID { get; set; }

		[JsonProperty]
		public bool? ISLIST { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? PARAMMULTIPLICITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(250 BYTE)")]
		public string PARMDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? PARMNUMBER { get; set; }

		[JsonProperty]
		public uint? TYPEMULTIPLICITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

	}

}
