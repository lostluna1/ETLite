using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_EXCEPTIONREASON", DisableSyncStructure = true)]
	public partial class BIZEXCEPTIONREASON {

		[JsonProperty, Column(Name = "BIZ_EXCEPTIONREASONID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZEXCEPTIONREASONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EXCEPTIONREASONNAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZEXCEPTIONREASONNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EXCEPTIONTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZEXCEPTIONTYPEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
