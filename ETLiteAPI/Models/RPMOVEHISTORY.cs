using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_MOVE_HISTORY", DisableSyncStructure = true)]
	public partial class RPMOVEHISTORY {

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINER { get; set; }

		[JsonProperty, Column(Name = "CONTAINER_ID", DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "EMPLOYEE_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string EMPLOYEEDESC { get; set; }

		[JsonProperty, Column(Name = "EMPLOYEE_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "NG_QTY", DbType = "VARCHAR2(16 BYTE)")]
		public string NGQTY { get; set; }

		[JsonProperty, Column(Name = "PASS_QTY", DbType = "NUMBER(22)")]
		public decimal? PASSQTY { get; set; }

		[JsonProperty, Column(Name = "PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_DESC", DbType = "VARCHAR2(296 BYTE)")]
		public string RESOURCEDESC { get; set; }

		[JsonProperty, Column(Name = "RESOURCE_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(Name = "SPEC_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string SPECDESC { get; set; }

		[JsonProperty, Column(Name = "SPEC_NAME", DbType = "VARCHAR2(40 BYTE)")]
		public string SPECNAME { get; set; }

		[JsonProperty, Column(Name = "SPEC_SEQUENCE")]
		public uint? SPECSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

		[JsonProperty, Column(Name = "WO_QTY", DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
