using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "CSIVIEW_24HRFACTORYPERFORMANCE", DisableSyncStructure = true)]
	public partial class CSIVIEW24HRFACTORYPERFORMANCE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CALENDARSHIFTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(37 BYTE)")]
		public string CDONAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string FROMSTEP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string FROMSTEPID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FROMSTEPSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty]
		public uint? ISLASTSTEP { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTREFRESHDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MOVECYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string REASONCODEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STEPID { get; set; }

		[JsonProperty]
		public uint? STEPPASS { get; set; }

		[JsonProperty]
		public uint? STEPSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETCYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETUNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETYIELD { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TORESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

	}

}
