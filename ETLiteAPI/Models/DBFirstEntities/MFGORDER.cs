using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGORDER {

		public string MFGORDERID { get; set; }

		public string BEGINPRODUCTBASEID { get; set; }

		public string BEGINPRODUCTID { get; set; }

		public string BILLOFPROCESSBASEID { get; set; }

		public string BILLOFPROCESSID { get; set; }

		public string BIZ_COMPLETIONWAREHOUSEID { get; set; }

		public string BIZ_CUSTOMERID { get; set; }

		public string BIZ_CUSTOMERPO { get; set; }

		public string BIZ_CUSTOMERPRODUCT { get; set; }

		public string BIZ_FATHERMFGORDERID { get; set; }

		public string BIZ_FGWAREHOUSEID { get; set; }

		public string BIZ_MFGORDERPRESTATUSID { get; set; }

		public string BIZ_NUMBERINGRULEID { get; set; }

		public string BIZ_PO { get; set; }

		public string BIZ_PRODUCTIONVERSION { get; set; }

		public DateTime? BIZ_SHIPPINGDATE { get; set; }

		public string BIZ_SO { get; set; }

		public string BIZ_SONUM { get; set; }

		public string BIZ_TOPMOID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string COMPLETIONPLAN { get; set; }

		public string CONSUMINGORDER { get; set; }

		public string CONTAINERNUMBERINGRULEID { get; set; }

		public string CUSTOMERREFERENCE { get; set; }

		public string CUSTOMERREV { get; set; }

		public DateTime? DATESHIPPED { get; set; }

		public string DEFAULTLOT { get; set; }

		public string DEFAULTPUTAWAYSTOCKPOINT { get; set; }

		public string DESCRIPTION { get; set; }

		public string ERPBOMID { get; set; }

		public string ERPROUTEBASEID { get; set; }

		public string ERPROUTEID { get; set; }

		public DateTime? ES_ACTUALFINISHED { get; set; }

		public string ES_CHILDCONTAINERNUMBERINGRUID { get; set; }

		public uint? ES_CONTINUEONFAIL { get; set; }

		public string ES_CUSTOMADDRESSPOOLID { get; set; }

		public uint? ES_CUSTOMADDRESSQTY { get; set; }

		public string ES_IMEIADDRESSPOOLID { get; set; }

		public uint? ES_IMEIADDRESSQTY { get; set; }

		public string ES_MACADDRESSPOOLID { get; set; }

		public uint? ES_MACADDRESSQTY { get; set; }

		public string ES_MATERIALATTRIBUTES { get; set; }

		public string ES_PRODUCTIONBOMID { get; set; }

		public string ES_PROGRAMVARIANT { get; set; }

		public uint? ES_SERIALNUMBERQTY { get; set; }

		public uint? ES_STARTVIRTUALSN { get; set; }

		public string ES_TOOLPLANMATRIXID { get; set; }

		public uint? EXTERNALLYCONTROLLED { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISKITTINGORDER { get; set; }

		public string ISPREACTORSCHEDULEID { get; set; }

		public string ISRECIPEPLANID { get; set; }

		public string ISWORKFLOWBASEID { get; set; }

		public string ISWORKFLOWID { get; set; }

		public DateTime? LASTCHANGEDATE { get; set; }

		public DateTime? LATESTCUSTOMERREQUIREDDATE { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGORDERNAME { get; set; }

		public string MODELNUMBER { get; set; }

		public DateTime? MPSDATE { get; set; }

		public string NOTES { get; set; }

		public string ORDERSTATUSID { get; set; }

		public string ORDERTYPEID { get; set; }

		public string ORIGINALCOMPLETIONPLAN { get; set; }

		public DateTime? ORIGINALPMDEMANDDATE { get; set; }

		public string ORIGINALSHIPPLANANDRBWCOMMIT { get; set; }

		public string PISO { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATEGMT { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public DateTime? PLANNEDSTARTDATEGMT { get; set; }

		public DateTime? PMDEMANDDATE { get; set; }

		public string PONUMBER { get; set; }

		public DateTime? POSTPRODUCTIONCOMPLETEDATEGMT { get; set; }

		public string POSTPRODUCTIONPROCEDUREID { get; set; }

		public uint? POSTPRODUCTIONPROCEDURESTATE { get; set; }

		public DateTime? POSTPRODUCTIONSTARTDATEGMT { get; set; }

		public DateTime? PREPRODUCTIONCOMPLETEDATEGMT { get; set; }

		public string PREPRODUCTIONPROCEDUREID { get; set; }

		public uint? PREPRODUCTIONPROCEDUREREQUIRED { get; set; }

		public uint? PREPRODUCTIONPROCEDURESTATE { get; set; }

		public DateTime? PREPRODUCTIONSTARTDATEGMT { get; set; }

		public string PRIORITYID { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTCONVERSIONPLANID { get; set; }

		public string PRODUCTID { get; set; }

		public DateTime? PRODUCTIONCOMPLETEDATEGMT { get; set; }

		public DateTime? PRODUCTIONSTARTDATEGMT { get; set; }

		public string PROJECTCODE { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public decimal? QTY2STARTED { get; set; }

		public decimal? QTYSTARTED { get; set; }

		public DateTime? RELEASEDATE { get; set; }

		public DateTime? RELEASEDATEGMT { get; set; }

		public string REPORTINGFACTORYID { get; set; }

		public string REWORKID { get; set; }

		public string RMANUMBER { get; set; }

		public string RSDCOMMITMENT { get; set; }

		public string SETUPACCESSID { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
