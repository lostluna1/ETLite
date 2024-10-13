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
	public partial class PREWORKSCRAPINFO {

		[JsonProperty, Column(Name = "AB_SCRAP_RATE", DbType = "CHAR(0 BYTE)")]
		public string ABSCRAPRATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string ABCONFIRMSCRAPQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string BUNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string CLASSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string CONFIRMSCRAPQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string DEFECTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string DEPTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEE { get; set; }

		[JsonProperty, Column(Name = "HIV2_ITEM_CODE", DbType = "VARCHAR2(100 BYTE)")]
		public string HIV2ITEMCODE { get; set; }

		[JsonProperty, Column(Name = "HIV3_ITEM_CODE", DbType = "VARCHAR2(100 BYTE)")]
		public string HIV3ITEMCODE { get; set; }

		[JsonProperty, Column(Name = "HU_USER_NAME", DbType = "CHAR(0 BYTE)")]
		public string HUUSERNAME { get; set; }

		[JsonProperty, Column(Name = "MANUFACTURING_CLASS", DbType = "CHAR(0 BYTE)")]
		public string MANUFACTURINGCLASS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERSTATUSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(256 BYTE)")]
		public string PREWORKSCAPNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string QTY { get; set; }

		[JsonProperty, Column(Name = "REQUIREMENT_QTY", DbType = "NUMBER(22)")]
		public decimal? REQUIREMENTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCRAPQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCRAPRATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SCRAPREASON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(3 BYTE)")]
		public string SCRAPSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCRAPTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SCRAPTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SENTALREADYQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SENTSHOUDLEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(56 BYTE)")]
		public string SPEC { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SUMSCRAPQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOM { get; set; }

		[JsonProperty, Column(Name = "WO_QTY", DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
