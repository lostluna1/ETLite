using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINER {

		public string CONTAINERID { get; set; }

		public string BATCHCOMMENTS { get; set; }

		public string BATCHID { get; set; }

		public uint? BATCHSTATUS { get; set; }

		public string BILLOFPROCESSID { get; set; }

		public string BINSIZE { get; set; }

		public string BIZ_CUSTOMERPARENTLOT { get; set; }

		public uint? BIZ_ISROLLBACK { get; set; }

		public string BIZ_NGCONTAINER { get; set; }

		public string BIZ_RFID { get; set; }

		public string BOMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string CONSUMINGORDER { get; set; }

		public string CONTAINERCOMMENTS { get; set; }

		public string CONTAINERNAME { get; set; }

		public string CONTAINERSTARTGUID { get; set; }

		public uint? CURRENTHOLDCOUNT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public uint? CURRENTTHRUPUTCHILDCOUNT { get; set; }

		public decimal? CURRENTTHRUPUTQTY { get; set; }

		public decimal? CURRENTTHRUPUTQTY2 { get; set; }

		public uint? CURRENTTHRUPUTUNITCOUNT { get; set; }

		public string CUSTOMERID { get; set; }

		public string CUSTOMERSERIALNUMBER { get; set; }

		public string DATECODE { get; set; }

		public string DESCRIPTION { get; set; }

		public string DETAILID { get; set; }

		public uint? DIRECTION { get; set; }

		public DateTime? DUEDATE { get; set; }

		public DateTime? DUEDATEGMT { get; set; }

		public uint? ES_HOLDTYPE { get; set; }

		public DateTime? ES_LASTSYSTEMDATE { get; set; }

		public DateTime? ES_LASTSYSTEMDATEGMT { get; set; }

		public DateTime? ES_MANUFACTURINGDATE { get; set; }

		public uint? ES_NFFDEFECTCOUNT { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public decimal? ES_WAITTIME { get; set; }

		public string ES_WORKFLOWID { get; set; }

		public string ES_WORKFLOWSTEPID { get; set; }

		public uint? ES_XOUT { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public DateTime? EXPIRATIONDATEGMT { get; set; }

		public DateTime? FACTORYSTARTDATE { get; set; }

		public DateTime? FACTORYSTARTDATEGMT { get; set; }

		public decimal? FACTORYSTARTQTY { get; set; }

		public decimal? FACTORYSTARTQTY2 { get; set; }

		public string FACTORYSTARTUOM2ID { get; set; }

		public string FACTORYSTARTUOMID { get; set; }

		public string FEEDERID { get; set; }

		public string HOLDREASONID { get; set; }

		public uint? INQUALITYCONTROL { get; set; }

		public string ISASSOCIATEDCARRIERID { get; set; }

		public uint? ISAUTOSTART { get; set; }

		public uint? ISCARRIER { get; set; }

		public uint? ISCARRIERSLOT { get; set; }

		public uint? ISFAILED { get; set; }

		public string ISHOLDREASONNAME { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public uint? ISMATERIALMANAGEENABLED { get; set; }

		public string ISPRODUCTNAME { get; set; }

		public string ISPRODUCTREVISION { get; set; }

		public uint? ISREPAIREDDEFECTCOUNT { get; set; }

		public string ISSUEDTOCONTAINERID { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		public string LASTCARRIERID { get; set; }

		public DateTime? LASTCOMPLETIONDATE { get; set; }

		public DateTime? LASTCOMPLETIONDATEGMT { get; set; }

		public string LASTINTEGRATIONTXNID { get; set; }

		public string LASTREVTXNID { get; set; }

		public uint? LEADFREE { get; set; }

		public string LEVELID { get; set; }

		public string LINENUMBER { get; set; }

		public string MASTERRECIPEID { get; set; }

		public decimal? MATERIALEXPOSUREOFFSET { get; set; }

		public decimal? MATERIALTOTALEXPOSURE { get; set; }

		public uint? MATERIALTOTALRETURNS { get; set; }

		public DateTime? MATERIALWITHDRAWALDATE { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGPARTNUMBER { get; set; }

		public decimal? MOVEINQTY { get; set; }

		public decimal? MOVEINQTY2 { get; set; }

		public string NICKNAME { get; set; }

		public DateTime? ONHOLDDATE { get; set; }

		public string ORIGINALCONTAINERID { get; set; }

		public string ORIGINALFACTORYID { get; set; }

		public decimal? ORIGINALQTY { get; set; }

		public decimal? ORIGINALQTY2 { get; set; }

		public DateTime? ORIGINALSTARTDATE { get; set; }

		public DateTime? ORIGINALSTARTDATEGMT { get; set; }

		public string ORIGINALUOM2ID { get; set; }

		public string ORIGINALUOMID { get; set; }

		public string OWNERID { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string PARENTNAME { get; set; }

		public string PLANNEDPRODUCTID { get; set; }

		public decimal? PLANNEDQTY { get; set; }

		public decimal? PLANNEDQTY2 { get; set; }

		public string PLANNEDQTYUOM2ID { get; set; }

		public string PLANNEDQTYUOMID { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public DateTime? PLANNEDSTARTDATEGMT { get; set; }

		public string PONUMBER { get; set; }

		public string PRIORITYCODEID { get; set; }

		public string PRODUCTID { get; set; }

		public uint? PRODUCTIONCOMPLETE { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public DateTime? RECEIVEDDATE { get; set; }

		public string REFERENCECONTAINERNAME { get; set; }

		public uint? RELATIVEPRIORITY { get; set; }

		public DateTime? REQUESTDATE { get; set; }

		public DateTime? REQUESTDATEGMT { get; set; }

		public string RMANUMBER { get; set; }

		public string SALESORDERID { get; set; }

		public string SAMPLINGLOTID { get; set; }

		public uint? SAMPLINGPASSED { get; set; }

		public uint? SAMPLINGREQUIRED { get; set; }

		public string SHAPENAME { get; set; }

		public string SPCCHARTSAVEOPTIONSENUMID { get; set; }

		public string SPECSTATUSID { get; set; }

		public string SPLITFROMID { get; set; }

		public string STARTPARENTCONTAINERID { get; set; }

		public string STARTREASONID { get; set; }

		public uint? STATUS { get; set; }

		public string SUPPLIER { get; set; }

		public string SUPPLYFROMNAME { get; set; }

		public string SUPPLYFROMTYPE { get; set; }

		public uint? THISCONTAINERLOST { get; set; }

		public uint? THRUPUTADJUSTMENTCHILDCOUNT { get; set; }

		public decimal? THRUPUTADJUSTMENTQTY { get; set; }

		public decimal? THRUPUTADJUSTMENTQTY2 { get; set; }

		public uint? THRUPUTADJUSTMENTUNITCOUNT { get; set; }

		public uint? UNITCOUNT { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public string VENDORITEMID { get; set; }

		public string VENDORLOTNUMBER { get; set; }

		public string VENDORNAME { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
