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
	public partial class SCHEDULEDBUSINESSRULE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SCHEDULEDBUSINESSRULEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty]
		public uint? DAYOFMONTH { get; set; }

		[JsonProperty]
		public uint? DAYOFWEEK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUETIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUETIMEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EXECUTIONCONTEXT { get; set; }

		[JsonProperty]
		public uint? EXECUTIONCONTEXTTYPE { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISADVANCEDMODE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLASTDAYOFMONTH { get; set; }

		[JsonProperty]
		public uint? ISSYSTEMDEFINED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string LOCKGUID { get; set; }

		[JsonProperty]
		public uint? MONTHOFYEAR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ONEXECUTE { get; set; }

		[JsonProperty]
		public uint? RECURRENCECOUNT { get; set; }

		[JsonProperty]
		public uint? RECURRENCEFREQUENCY { get; set; }

		[JsonProperty]
		public uint? RECURRENCEPATTERN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEDAYSOFMONTH { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEDAYSOFWEEK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SCHEDULEDBUSINESSRULENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEHOURS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SCHEDULEMONTHS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? STARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? STARTDATEGMT { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
