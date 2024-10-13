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
	public partial class BUSINESSPROCESSSPEC {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BUSINESSPROCESSSPECID { get; set; }

		[JsonProperty]
		public uint? ASSIGNAPPROVERS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BUSINESSPROCESSSPECBASEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? LOCKINSTANCES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MOVESTDVALIDATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? PACKAGESTATUS { get; set; }

		[JsonProperty]
		public uint? REQUIRESAPPROVAL { get; set; }

		[JsonProperty]
		public uint? RESETAPPROVALS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string STEPICON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
