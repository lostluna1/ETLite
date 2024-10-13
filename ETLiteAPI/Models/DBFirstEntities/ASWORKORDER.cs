using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "AS_WORKORDER", DisableSyncStructure = true)]
	public partial class ASWORKORDER {

		[JsonProperty, Column(Name = "BIZ_COMPLETIONWAREHOUSE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCOMPLETIONWAREHOUSE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMER { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMERPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_FATHERMFGORDER", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZFATHERMFGORDER { get; set; }

		[JsonProperty, Column(Name = "BIZ_FEEDWH", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZFEEDWH { get; set; }

		[JsonProperty, Column(Name = "BIZ_FGWAREHOUSE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZFGWAREHOUSE { get; set; }

		[JsonProperty, Column(Name = "BIZ_PO", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZPO { get; set; }

		[JsonProperty, Column(Name = "BIZ_SHIPPINGDATE", DbType = "DATE(7)")]
		public DateTime? BIZSHIPPINGDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SO", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSO { get; set; }

		[JsonProperty, Column(Name = "BIZ_SONUM", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSONUM { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUPPLYTYPE", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZSUPPLYTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOPMO", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZTOPMO { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOTALREQUIRED", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZTOTALREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BOMUOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string ERPLINEITEM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string ERPROUTE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string ERPROUTEREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MATERIAL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string MATERIALREVISION { get; set; }

		[JsonProperty]
		public uint? MATERIALTXNLOGIC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDER { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ORDERQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERSTATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERTYPE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string PRODUCTIONREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QUANTITYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REPORTINGFACTORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SPEC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string SPECREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOM { get; set; }

	}

}
