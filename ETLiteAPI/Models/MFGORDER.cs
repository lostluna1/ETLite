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
	public partial class MFGORDER {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BEGINPRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BEGINPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLOFPROCESSBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLOFPROCESSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_COMPLETIONWAREHOUSEID", DbType = "CHAR(16 BYTE)")]
		public string BIZCOMPLETIONWAREHOUSEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERID", DbType = "CHAR(16 BYTE)")]
		public string BIZCUSTOMERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPO", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZCUSTOMERPO { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMERPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_FATHERMFGORDERID", DbType = "CHAR(16 BYTE)")]
		public string BIZFATHERMFGORDERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FGWAREHOUSEID", DbType = "CHAR(16 BYTE)")]
		public string BIZFGWAREHOUSEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MFGORDERPRESTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZMFGORDERPRESTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_NUMBERINGRULEID", DbType = "CHAR(16 BYTE)")]
		public string BIZNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PO", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZPO { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTIONVERSION", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZPRODUCTIONVERSION { get; set; }

		[JsonProperty, Column(Name = "BIZ_SHIPPINGDATE", DbType = "DATE(7)")]
		public DateTime? BIZSHIPPINGDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SO", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSO { get; set; }

		[JsonProperty, Column(Name = "BIZ_SONUM", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSONUM { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOPMOID", DbType = "CHAR(16 BYTE)")]
		public string BIZTOPMOID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string COMPLETIONPLAN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CONSUMINGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERREFERENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CUSTOMERREV { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DATESHIPPED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEFAULTLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEFAULTPUTAWAYSTOCKPOINT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEID { get; set; }

		[JsonProperty, Column(Name = "ES_ACTUALFINISHED", DbType = "DATE(7)")]
		public DateTime? ESACTUALFINISHED { get; set; }

		[JsonProperty, Column(Name = "ES_CHILDCONTAINERNUMBERINGRUID", DbType = "CHAR(16 BYTE)")]
		public string ESCHILDCONTAINERNUMBERINGRUID { get; set; }

		[JsonProperty, Column(Name = "ES_CONTINUEONFAIL")]
		public uint? ESCONTINUEONFAIL { get; set; }

		[JsonProperty, Column(Name = "ES_CUSTOMADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESCUSTOMADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_CUSTOMADDRESSQTY")]
		public uint? ESCUSTOMADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_IMEIADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESIMEIADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_IMEIADDRESSQTY")]
		public uint? ESIMEIADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_MACADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESMACADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_MACADDRESSQTY")]
		public uint? ESMACADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_MATERIALATTRIBUTES", DbType = "VARCHAR2(30 BYTE)")]
		public string ESMATERIALATTRIBUTES { get; set; }

		[JsonProperty, Column(Name = "ES_PRODUCTIONBOMID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODUCTIONBOMID { get; set; }

		[JsonProperty, Column(Name = "ES_PROGRAMVARIANT", DbType = "VARCHAR2(30 BYTE)")]
		public string ESPROGRAMVARIANT { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERQTY")]
		public uint? ESSERIALNUMBERQTY { get; set; }

		[JsonProperty, Column(Name = "ES_STARTVIRTUALSN")]
		public uint? ESSTARTVIRTUALSN { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANMATRIXID", DbType = "CHAR(16 BYTE)")]
		public string ESTOOLPLANMATRIXID { get; set; }

		[JsonProperty]
		public uint? EXTERNALLYCONTROLLED { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISKITTINGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPREACTORSCHEDULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISWORKFLOWBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISWORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCHANGEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LATESTCUSTOMERREQUIREDDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MODELNUMBER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MPSDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORDERSTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORDERTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ORIGINALCOMPLETIONPLAN { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ORIGINALPMDEMANDDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ORIGINALSHIPPLANANDRBWCOMMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PISO { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PMDEMANDDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PONUMBER { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? POSTPRODUCTIONCOMPLETEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string POSTPRODUCTIONPROCEDUREID { get; set; }

		[JsonProperty]
		public uint? POSTPRODUCTIONPROCEDURESTATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? POSTPRODUCTIONSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PREPRODUCTIONCOMPLETEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PREPRODUCTIONPROCEDUREID { get; set; }

		[JsonProperty]
		public uint? PREPRODUCTIONPROCEDUREREQUIRED { get; set; }

		[JsonProperty]
		public uint? PREPRODUCTIONPROCEDURESTATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PREPRODUCTIONSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTCONVERSIONPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PRODUCTIONCOMPLETEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PRODUCTIONSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PROJECTCODE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2STARTED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYSTARTED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RELEASEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RELEASEDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPORTINGFACTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REWORKID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RMANUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RSDCOMMITMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
