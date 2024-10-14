using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPCRITICALSPECDASHBOARD {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACHIEVEMENT { get; set; }

		[JsonProperty, Column(Name = "ACTUAL_QTY", DbType = "NUMBER(22)")]
		public decimal? ACTUALQTY { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string ENDTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(Name = "FACTOTY_NOTES", DbType = "VARCHAR2(2000 BYTE)")]
		public string FACTOTYNOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "SPEC_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string SPECDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SPECNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string STARTTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(10 BYTE)")]
		public string TXNDATE { get; set; }

	}

}
