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
	public partial class SAMPLEDATAPOINT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SAMPLEDATAPOINTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FSS_CODEID", DbType = "CHAR(16 BYTE)")]
		public string BIZFSSCODEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISMETGNO")]
		public uint? BIZISMETGNO { get; set; }

		[JsonProperty, Column(Name = "BIZ_MOLD_TYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZMOLDTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_POINTTYPE")]
		public uint? BIZPOINTTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAMPLEDATAPOINTTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZSAMPLEDATAPOINTTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAMPLEQTY", DbType = "NUMBER(22)")]
		public decimal? BIZSAMPLEQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SEQUENCE")]
		public uint? BIZSEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SPC")]
		public uint? BIZSPC { get; set; }

		[JsonProperty, Column(Name = "BIZ_SPCMODULE", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZSPCMODULE { get; set; }

		[JsonProperty, Column(Name = "BIZ_TER_ITEM_CODEID", DbType = "CHAR(16 BYTE)")]
		public string BIZTERITEMCODEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ZFORMAT", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZZFORMAT { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty]
		public uint? DATATYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEFAULTVALUE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLEDATAPOINTBASEID { get; set; }

		[JsonProperty]
		public uint? SHOWLIMITS { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
