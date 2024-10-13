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
	public partial class MAINTENANCEREQ {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MAINTENANCEREQID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SCHEDULECOMPLETIONDATE", DbType = "DATE(7)")]
		public DateTime? BIZSCHEDULECOMPLETIONDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SCHEDULEWORKINGHOUR")]
		public uint? BIZSCHEDULEWORKINGHOUR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALCULATEDENDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALCULATEDENDDATEGMT { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty]
		public uint? DAYOFMONTH { get; set; }

		[JsonProperty]
		public uint? DAYOFWEEK { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DUEEMAILTEXT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ENDDATEGMT { get; set; }

		[JsonProperty]
		public uint? ENFORCECHECKLISTSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ESTIMATEDDURATION { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTMAINTDATEDUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTMAINTDATEDUEGMT { get; set; }

		[JsonProperty]
		public uint? FREQUENCY { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBMODELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MAINTENANCEREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MAINTENANCEREQBASEID { get; set; }

		[JsonProperty]
		public uint? MONTHOFYEAR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? OCCURRENCES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string PASTDUEEMAILTEXT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string PENDINGEMAILTEXT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty]
		public uint? RECURRINGDATEPATTERN { get; set; }

		[JsonProperty]
		public uint? RECURRINGDATETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string REVISION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCHEDULEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SEEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SEEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOLERANCEPERIOD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOLERANCEQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOLERANCEQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WARNINGPERIOD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WARNINGQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WARNINGQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
