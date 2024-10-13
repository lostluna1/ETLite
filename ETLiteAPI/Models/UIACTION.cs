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
	public partial class UIACTION {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string UIACTIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ACTIONCATEGORYID { get; set; }

		[JsonProperty]
		public uint? BUTTONPOSITION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BUTTONSLAYOUTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CLEARVALUES { get; set; }

		[JsonProperty]
		public uint? CLOSEBUTTONONLY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CONDITIONHANDLER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CUSTOMMETHODHANDLER { get; set; }

		[JsonProperty]
		public uint? DENYDATACONTRACT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DISABLECONDITION { get; set; }

		[JsonProperty]
		public uint? DISPLAYMODE { get; set; }

		[JsonProperty]
		public uint? ESIGREQUIRED { get; set; }

		[JsonProperty]
		public uint? EXECUTEONSUBMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? FORCEREDIRECT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FRAMELOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string HIDDENCONDITION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HORIZONTALSHIFTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string INITCONTRACTHANDLER { get; set; }

		[JsonProperty]
		public uint? ISDISABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISHIDDEN { get; set; }

		[JsonProperty]
		public uint? ISPRIMARY { get; set; }

		[JsonProperty]
		public uint? ISRETURN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(66 BYTE)")]
		public string LABELNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LABELTEXT { get; set; }

		[JsonProperty]
		public uint? LOCATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MAPITEM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string PARAMETERS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PERMISSIONSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PORTALTABID { get; set; }

		[JsonProperty]
		public uint? PORTALTABOPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUERYSTRINGPARAMETERSID { get; set; }

		[JsonProperty]
		public uint? RELOADVALUES { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SERVICENAME { get; set; }

		[JsonProperty]
		public uint? SHOWBUTTONS { get; set; }

		[JsonProperty]
		public uint? SIDEBARCOLLECTIBLE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SIDEBARCSS { get; set; }

		[JsonProperty]
		public uint? SPCENABLED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UIACTIONNAME { get; set; }

		[JsonProperty]
		public uint? UIINDEX { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UIPAGEFLOWID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UIVIRTUALPAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string URL { get; set; }

		[JsonProperty]
		public uint? WIPMESSAGESREQUIRED { get; set; }

	}

}
