using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QTYEFFICIENCYDATA1 {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACHIEVEMENT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALOUTPUT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(2 BYTE)")]
		public string BREAKTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? EFFICIENCY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ETUBOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(1 BYTE)")]
		public string HOURSINVESTED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(2 BYTE)")]
		public string MANPOWER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "NG_QTY", DbType = "NUMBER(22)")]
		public decimal? NGQTY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NOWDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PBDESC { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANOUTPUT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? RETURNQTY { get; set; }

		[JsonProperty, Column(Name = "SHIFT_QTY", DbType = "CHAR(4 BYTE)")]
		public string SHIFTQTY { get; set; }

		[JsonProperty, Column(Name = "SHIFT_TIME_END", DbType = "CHAR(18 BYTE)")]
		public string SHIFTTIMEEND { get; set; }

		[JsonProperty, Column(Name = "SHIFT_TIME_START", DbType = "CHAR(17 BYTE)")]
		public string SHIFTTIMESTART { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(Name = "STA_TIME", DbType = "CHAR(3 BYTE)")]
		public string STATIME { get; set; }

		[JsonProperty, Column(Name = "TEST_QTY", DbType = "NUMBER(22)")]
		public decimal? TESTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TOTQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOMNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELD { get; set; }

	}

}
