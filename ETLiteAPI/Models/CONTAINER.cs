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
	public partial class CONTAINER {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string BATCHCOMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BATCHID { get; set; }

		[JsonProperty]
		public uint? BATCHSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLOFPROCESSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string BINSIZE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPARENTLOT", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZCUSTOMERPARENTLOT { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISROLLBACK")]
		public uint? BIZISROLLBACK { get; set; }

		[JsonProperty, Column(Name = "BIZ_NGCONTAINER", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZNGCONTAINER { get; set; }

		[JsonProperty, Column(Name = "BIZ_RFID", DbType = "CHAR(16 BYTE)")]
		public string BIZRFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CONSUMINGORDER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string CONTAINERCOMMENTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CONTAINERSTARTGUID { get; set; }

		[JsonProperty]
		public uint? CURRENTHOLDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CURRENTSTATUSID { get; set; }

		[JsonProperty]
		public uint? CURRENTTHRUPUTCHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CURRENTTHRUPUTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CURRENTTHRUPUTQTY2 { get; set; }

		[JsonProperty]
		public uint? CURRENTTHRUPUTUNITCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DATECODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DETAILID { get; set; }

		[JsonProperty]
		public uint? DIRECTION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEDATEGMT { get; set; }

		[JsonProperty, Column(Name = "ES_HOLDTYPE")]
		public uint? ESHOLDTYPE { get; set; }

		[JsonProperty, Column(Name = "ES_LASTSYSTEMDATE", DbType = "DATE(7)")]
		public DateTime? ESLASTSYSTEMDATE { get; set; }

		[JsonProperty, Column(Name = "ES_LASTSYSTEMDATEGMT", DbType = "DATE(7)")]
		public DateTime? ESLASTSYSTEMDATEGMT { get; set; }

		[JsonProperty, Column(Name = "ES_MANUFACTURINGDATE", DbType = "DATE(7)")]
		public DateTime? ESMANUFACTURINGDATE { get; set; }

		[JsonProperty, Column(Name = "ES_NFFDEFECTCOUNT")]
		public uint? ESNFFDEFECTCOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_PRIMARYSERIALNUMBER", DbType = "VARCHAR2(100 BYTE)")]
		public string ESPRIMARYSERIALNUMBER { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER2", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER2 { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBER3", DbType = "VARCHAR2(100 BYTE)")]
		public string ESSERIALNUMBER3 { get; set; }

		[JsonProperty, Column(Name = "ES_WAITTIME", DbType = "NUMBER(22)")]
		public decimal? ESWAITTIME { get; set; }

		[JsonProperty, Column(Name = "ES_WORKFLOWID", DbType = "CHAR(16 BYTE)")]
		public string ESWORKFLOWID { get; set; }

		[JsonProperty, Column(Name = "ES_WORKFLOWSTEPID", DbType = "CHAR(16 BYTE)")]
		public string ESWORKFLOWSTEPID { get; set; }

		[JsonProperty, Column(Name = "ES_XOUT")]
		public uint? ESXOUT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPIRATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXPIRATIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FACTORYSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FACTORYSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FACTORYSTARTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FACTORYSTARTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYSTARTUOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYSTARTUOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HOLDREASONID { get; set; }

		[JsonProperty]
		public uint? INQUALITYCONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISASSOCIATEDCARRIERID { get; set; }

		[JsonProperty]
		public uint? ISAUTOSTART { get; set; }

		[JsonProperty]
		public uint? ISCARRIER { get; set; }

		[JsonProperty]
		public uint? ISCARRIERSLOT { get; set; }

		[JsonProperty]
		public uint? ISFAILED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISHOLDREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISINVENTORYLOCATIONID { get; set; }

		[JsonProperty]
		public uint? ISMATERIALMANAGEENABLED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISPRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string ISPRODUCTREVISION { get; set; }

		[JsonProperty]
		public uint? ISREPAIREDDEFECTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSUEDTOCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTCARRIERID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTINTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty]
		public uint? LEADFREE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LEVELID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string LINENUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MASTERRECIPEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MATERIALEXPOSUREOFFSET { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MATERIALTOTALEXPOSURE { get; set; }

		[JsonProperty]
		public uint? MATERIALTOTALRETURNS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MATERIALWITHDRAWALDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MFGPARTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MOVEINQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MOVEINQTY2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string NICKNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ONHOLDDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORIGINALCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORIGINALFACTORYID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ORIGINALQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ORIGINALQTY2 { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ORIGINALSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ORIGINALSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORIGINALUOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORIGINALUOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARENTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PLANNEDPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANNEDQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANNEDQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PLANNEDQTYUOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PLANNEDQTYUOMID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PONUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty]
		public uint? PRODUCTIONCOMPLETE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2 { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RECEIVEDDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REFERENCECONTAINERNAME { get; set; }

		[JsonProperty]
		public uint? RELATIVEPRIORITY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REQUESTDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REQUESTDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RMANUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SALESORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGLOTID { get; set; }

		[JsonProperty]
		public uint? SAMPLINGPASSED { get; set; }

		[JsonProperty]
		public uint? SAMPLINGREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SHAPENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCCHARTSAVEOPTIONSENUMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECSTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPLITFROMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STARTPARENTCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STARTREASONID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SUPPLIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SUPPLYFROMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SUPPLYFROMTYPE { get; set; }

		[JsonProperty]
		public uint? THISCONTAINERLOST { get; set; }

		[JsonProperty]
		public uint? THRUPUTADJUSTMENTCHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTADJUSTMENTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTADJUSTMENTQTY2 { get; set; }

		[JsonProperty]
		public uint? THRUPUTADJUSTMENTUNITCOUNT { get; set; }

		[JsonProperty]
		public uint? UNITCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string VENDORITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string VENDORLOTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string VENDORNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
