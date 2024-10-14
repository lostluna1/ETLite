using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZFAIINSPECTIONTASKCHILD {

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKCHILDID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFAIINSPECTIONTASKCHILDID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKCHILDNAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZFAIINSPECTIONTASKCHILDNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISUPLOADSPC")]
		public uint? BIZISUPLOADSPC { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAMPLEDATAPOINTTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZSAMPLEDATAPOINTTYPEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? FINALJUDGMENT { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(30 BYTE)")]
		public string LOWERLIMIT { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string LOWERLIMIT1 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? QCCONFRIM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string RESULTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SAMPLEDATAPOINT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SAMPLEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(64 BYTE)")]
		public string SAMPLETEST { get; set; }

		[JsonProperty]
		public uint? SAMPLETYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SAMPLINGPLAN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SEQ { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(64 BYTE)")]
		public string SN { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(64 BYTE)")]
		public string TASKNO { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(30 BYTE)")]
		public string UPPERLIMIT { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string UPPERLIMIT1 { get; set; }

	}

}
