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
	public partial class SPCCHARTDEF {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SPCCHARTDEFID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty]
		public uint? CHARTHEIGHT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CHARTPROPERTIES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CHARTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CHARTVARIABLE { get; set; }

		[JsonProperty]
		public uint? CHARTWIDTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DISPLAYONEXCEPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCTOVIEWID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMAILMESSAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EMAILNOTIFICATION { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISNEWSPC { get; set; }

		[JsonProperty]
		public uint? LEGENDLOCATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string MACRO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PUTCONTAINERONHOLDID { get; set; }

		[JsonProperty]
		public uint? RECORDAGAINSTCUSTOMSPCDATASRC { get; set; }

		[JsonProperty]
		public uint? REQUIREANNOTATION { get; set; }

		[JsonProperty]
		public uint? RUNTIMEDISPLAY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETRESOURCESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SPCCHARTDEFNAME { get; set; }

		[JsonProperty]
		public uint? SPCCHARTDISPLAYOPTION { get; set; }

		[JsonProperty]
		public uint? SPCCHARTSAVEOPTIONS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCCHARTTYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCCONNECTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCQUERYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCRULESID { get; set; }

		[JsonProperty]
		public uint? TRIGGEROCAPS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM1 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM10 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM3 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM4 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM5 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM6 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM7 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM8 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string USERPARM9 { get; set; }

	}

}
