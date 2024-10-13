using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_COMPONENTISSUEDETAILSLITE", DisableSyncStructure = true)]
	public partial class RVCOMPONENTISSUEDETAILSLITE {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALQTYISSUED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PRIMARYSERIALNUMBER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER2", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER3", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER3 { get; set; }

		[JsonProperty]
		public uint? FAILED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FROMLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string FROMSERIALNUMBER3 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FROMSTOCKPOINT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREMOVED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string WORKFLOWREVISION { get; set; }

		[JsonProperty]
		public uint? XOUT { get; set; }

	}

}
