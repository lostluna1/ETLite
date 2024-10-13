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
	public partial class ISPREACTORSCHEDULEDORDERS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISPREACTORSCHEDULEDORDERSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CONTAINERSPROCESSEDQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? DURATION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPOPERATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ERPOPERATIONNO { get; set; }

		[JsonProperty, Column(Name = "ES_MFGLINEID", DbType = "CHAR(16 BYTE)")]
		public string ESMFGLINEID { get; set; }

		[JsonProperty, Column(Name = "ES_SMTGROUPING", DbType = "VARCHAR2(255 BYTE)")]
		public string ESSMTGROUPING { get; set; }

		[JsonProperty, Column(Name = "ES_STARTVIRTUALSN")]
		public uint? ESSTARTVIRTUALSN { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FINISHEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FINISHEDDATEGMT { get; set; }

		[JsonProperty]
		public uint? ISCHECKEDCONTAINER { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISPREACTORSCHEDULEDORDERSNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPREACTORSCHEDULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRESOLVEDCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LINEASSIGNMENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MFGORDERQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OPERATIONID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PRIORITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SCHEDULINGOPERATIONNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCHEDULINGOPERATIONNO { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STATUSID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TIMEPERBATCH { get; set; }

		[JsonProperty]
		public uint? UNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UNSCHEDULEDTIME { get; set; }

	}

}
