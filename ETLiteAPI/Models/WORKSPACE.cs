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
	public partial class WORKSPACE {

		[JsonProperty, Column(IsPrimary = true)]
		public uint WORKSPACEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COLOR { get; set; }

		[JsonProperty]
		public uint? DEFAULTFEATUREID { get; set; }

		[JsonProperty]
		public uint? ENDCDOID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(10 BYTE)")]
		public string ENDCDOIDHEX { get; set; }

		[JsonProperty]
		public uint? ENDID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(10 BYTE)")]
		public string ENDIDHEX { get; set; }

		[JsonProperty]
		public bool? ISACTIVE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PREFIX { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty]
		public uint? STARTCDOID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(10 BYTE)")]
		public string STARTCDOIDHEX { get; set; }

		[JsonProperty]
		public uint? STARTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(10 BYTE)")]
		public string STARTIDHEX { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(50 BYTE)")]
		public string SUPPORTEDBY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string WORKSPACECODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string WORKSPACEDESCRIPTION { get; set; }

	}

}
