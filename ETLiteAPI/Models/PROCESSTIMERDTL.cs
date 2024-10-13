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
	public partial class PROCESSTIMERDTL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PROCESSTIMERDTLID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BUSINESSRULEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLASSIFICATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DEFAULTFAILUREMODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DEFAULTPEDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HOLDREASONID { get; set; }

		[JsonProperty]
		public uint? ISBUSINESSRULE { get; set; }

		[JsonProperty]
		public uint? ISCONFIRMATION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISHOLD { get; set; }

		[JsonProperty]
		public uint? ISMOVENONSTD { get; set; }

		[JsonProperty]
		public uint? ISPRODUCTIONEVENT { get; set; }

		[JsonProperty]
		public uint? ISREWORK { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string PROCESSTIMERDTLNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REWORKREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SUBCLASSIFICATIONID { get; set; }

		[JsonProperty]
		public uint? TIMERACTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSTEPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string TOSTEPNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOWORKFLOWID { get; set; }

	}

}
