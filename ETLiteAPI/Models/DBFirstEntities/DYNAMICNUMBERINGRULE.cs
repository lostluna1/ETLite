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
	public partial class DYNAMICNUMBERINGRULE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string DYNAMICNUMBERINGRULEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DYNAMICNUMBERINGRULENAME { get; set; }

		[JsonProperty]
		public uint? EXCLUDEDVALUES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISROLLOVER { get; set; }

		[JsonProperty]
		public uint? LASTSEQUENCEVALUE { get; set; }

		[JsonProperty]
		public uint? MAXIMUMVALUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string NEWDYNAMICNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? NUMBERINGRULEOPTIONS { get; set; }

		[JsonProperty]
		public uint? NUMBERINGRULETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PREFIX { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOLVEDNUMBERINGRULEID { get; set; }

		[JsonProperty]
		public uint? SEQUENCELENGTH { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SUFFIX { get; set; }

		[JsonProperty]
		public uint? USEALPHANUMBERICVALUE { get; set; }

		[JsonProperty]
		public uint? USEHEXADECIMALVALUE { get; set; }

		[JsonProperty]
		public uint? USEPREFIXBASED { get; set; }

	}

}
