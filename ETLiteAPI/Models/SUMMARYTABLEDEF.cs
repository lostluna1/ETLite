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
	public partial class SUMMARYTABLEDEF {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SUMMARYTABLEDEFID { get; set; }

		[JsonProperty]
		public uint? APPENDTOTABLE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? FORCEEXECUTE { get; set; }

		[JsonProperty]
		public uint? FORCEREFRESH { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISENABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISMANUALLYEXECUTED { get; set; }

		[JsonProperty]
		public uint? ISVIEW { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTRUNDATE { get; set; }

		[JsonProperty]
		public uint? LASTRUNELAPSEDSECONDS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string LASTRUNMESSAGE { get; set; }

		[JsonProperty]
		public uint? LASTRUNSUCCESS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEXTRUNDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEDAYSOFMONTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEDAYSOFWEEK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEHOURS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEMONTHS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? STARTDATE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string SUMMARYSQL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SUMMARYTABLEDEFNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string TARGETSCHEMA { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string TARGETTABLENAME { get; set; }

	}

}
