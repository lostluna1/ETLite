using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_WIP_MFGORDER", DisableSyncStructure = true)]
	public partial class RVWIPMFGORDER {

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string AVGPROCESSTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FAILCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? INPROCESSCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? INQUEUECOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISOPTIONAL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ORDERQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PANELIZED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PCBCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PROCESSEDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string PROCESSTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string PRODUCTDISPLAY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYSTARTED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STARTEDQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string STEPDISPLAYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XOUTCOUNT { get; set; }

	}

}
