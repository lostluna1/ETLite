using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PRODUCT {

		public string PRODUCTID { get; set; }

		public string BILLOFPROCESSBASEID { get; set; }

		public string BILLOFPROCESSID { get; set; }

		public decimal? BIZ_ACTIVETIME { get; set; }

		public decimal? BIZ_ASSEMBLYSCRAPRATE { get; set; }

		public string BIZ_ATUOMID { get; set; }

		public string BIZ_BUID { get; set; }

		public string BIZ_EXTPRODUCT { get; set; }

		public string BIZ_EXTPURCHASEWHID { get; set; }

		public string BIZ_FAIPLANID { get; set; }

		public uint? BIZ_FAIQTY { get; set; }

		public string BIZ_FQCPLANID { get; set; }

		public uint? BIZ_FQCTYPE { get; set; }

		public decimal? BIZ_GROSSWEIGHT { get; set; }

		public string BIZ_IPQCPLANID { get; set; }

		public uint? BIZ_IPQCQTY { get; set; }

		public uint? BIZ_ISMOPCBARULE { get; set; }

		public string BIZ_LABELPRINTSETUPID { get; set; }

		public string BIZ_LABLECHECKPLANID { get; set; }

		public string BIZ_LAIPLANID { get; set; }

		public uint? BIZ_LAIQTY { get; set; }

		public string BIZ_MATERIALFAMILYID { get; set; }

		public uint? BIZ_MATERIALLT { get; set; }

		public string BIZ_MRPCONTROLLER { get; set; }

		public string BIZ_MULTIPLANTMATLSTATUSID { get; set; }

		public DateTime? BIZ_MULTPSTATUSEFFSTARTDATE { get; set; }

		public string BIZ_NETUOMID { get; set; }

		public decimal? BIZ_NETWEIGHT { get; set; }

		public decimal? BIZ_PACKINGQTY { get; set; }

		public string BIZ_PCBASN { get; set; }

		public string BIZ_POTYPEID { get; set; }

		public string BIZ_PRCGROUPID { get; set; }

		public string BIZ_PRODUCTIONWHID { get; set; }

		public string BIZ_PRODUCTRESOURCECHECKGROUID { get; set; }

		public string BIZ_PRODUCTRESOURCECHECKID { get; set; }

		public decimal? BIZ_SAFESTOCKQTY { get; set; }

		public uint? BIZ_SAMPLINGMEASUREQTY { get; set; }

		public decimal? BIZ_SCRAPRATE { get; set; }

		public uint? BIZ_SELFPRODUCTIONDAY { get; set; }

		public string BIZ_SINGLEPLANTMATLSTATUSID { get; set; }

		public DateTime? BIZ_SINGLEPSTATUSEFFSTARTDATE { get; set; }

		public string BIZ_SPECIALPOTYPEID { get; set; }

		public string BIZ_STDCOSTPRICE { get; set; }

		public uint? BIZ_STOCKQTY { get; set; }

		public string BIZ_STORAGELOCATION { get; set; }

		public string BIZ_SUPPLYTYPE { get; set; }

		public string BOMBASEID { get; set; }

		public string BOMID { get; set; }

		public string BRANDNAME { get; set; }

		public string CATALOGNUMBER { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		public string COMMENTS { get; set; }

		public string CONCOMITANTPRODUCTNUMBER { get; set; }

		public string CONTAINERNUMBERINGRULEID { get; set; }

		public decimal? CURRENTCOST { get; set; }

		public string CUSTOMERID { get; set; }

		public string CUSTOMERPART { get; set; }

		public string CUSTOMERPRODUCTNUMBER { get; set; }

		public string DESCRIPTION { get; set; }

		public string DEVICETYPE { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ECO { get; set; }

		public string ERPBOMBASEID { get; set; }

		public string ERPBOMID { get; set; }

		public string ERPPRODUCTFAMILY { get; set; }

		public string ERPROUTEBASEID { get; set; }

		public string ERPROUTEID { get; set; }

		public string ES_BOMBASEID { get; set; }

		public string ES_BOMID { get; set; }

		public string ES_CADINSTRUCTIONSID { get; set; }

		public string ES_CHILDSNRULEID { get; set; }

		public uint? ES_CONTAINERACTION { get; set; }

		public string ES_CUSTOMADDRESSPOOLID { get; set; }

		public uint? ES_CUSTOMADDRESSQTY { get; set; }

		public DateTime? ES_EFFECTIVEENDDATE { get; set; }

		public DateTime? ES_EFFECTIVEENDDATEGMT { get; set; }

		public DateTime? ES_EFFECTIVESTARTDATE { get; set; }

		public DateTime? ES_EFFECTIVESTARTDATEGMT { get; set; }

		public string ES_IMEIADDRESSPOOLID { get; set; }

		public uint? ES_IMEIADDRESSQTY { get; set; }

		public string ES_MACADDRESSPOOLID { get; set; }

		public uint? ES_MACADDRESSQTY { get; set; }

		public string ES_MASTERRECIPE { get; set; }

		public string ES_MATERIALATTRIBUTES { get; set; }

		public uint? ES_MOUNTINGTECHNOLOGY { get; set; }

		public string ES_NPIJOBBASEID { get; set; }

		public string ES_NPIJOBID { get; set; }

		public string ES_PARENTSNRULEID { get; set; }

		public uint? ES_PINCOUNT { get; set; }

		public uint? ES_POLARIZED { get; set; }

		public string ES_PRODUCTIONBOMBASEID { get; set; }

		public string ES_PRODUCTIONBOMID { get; set; }

		public uint? ES_RESETREWORKTOTALCOUNT { get; set; }

		public uint? ES_REWORKCYCLECHECK { get; set; }

		public uint? ES_REWORKCYCLELIMIT { get; set; }

		public string ES_REWORKHOLDREASONID { get; set; }

		public string ES_REWORKLOSSREASONID { get; set; }

		public string ES_SCHEMATICID { get; set; }

		public uint? ES_SERIALNUMBERCONFIG { get; set; }

		public uint? ES_SERIALNUMBERGENERATION { get; set; }

		public string ES_SERIALNUMBERPREFIX { get; set; }

		public uint? ES_SERIALNUMBERQTY { get; set; }

		public uint? ES_STARTVIRTUALSN { get; set; }

		public string ES_STDSTARTCHILDLEVELID { get; set; }

		public string ES_TOOLPLANMATRIXID { get; set; }

		public uint? ES_UNIQUESERIALNUMBERS { get; set; }

		public uint? ES_USECONTAINERNAMEFORSN { get; set; }

		public uint? EXTERNALLYCONTROLLED { get; set; }

		public uint? FEFOENFORCE { get; set; }

		public string FEFOOVERRIDEESIGREQUIREMENTID { get; set; }

		public string FILTERTAGS { get; set; }

		public string FREQUENCY { get; set; }

		public string GLENTITY { get; set; }

		public decimal? HEIGHT { get; set; }

		public uint? ICONID { get; set; }

		public uint? INSPECTALL { get; set; }

		public uint? INVENTORYCONTROLLED { get; set; }

		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISIMAGEID { get; set; }

		public uint? ISPHANTOM { get; set; }

		public string ISRECIPEPLANID { get; set; }

		public uint? ISREGISTERCONTAINERS { get; set; }

		public decimal? LENGTH { get; set; }

		public uint? LIFETIMELIMIT { get; set; }

		public uint? LIFETIMELIMIT2 { get; set; }

		public string LIMITSEMAILGROUPID { get; set; }

		public uint? LOTCONTROLLED { get; set; }

		public uint? MATERIALACCUMULATEEXPOSURE { get; set; }

		public string MATERIALCATEGORY { get; set; }

		public decimal? MATERIALEXPOSUREDURATION { get; set; }

		public uint? MATERIALMAXRETURNS { get; set; }

		public decimal? MATERIALTHAWINGDURATION { get; set; }

		public uint? MAXQTY { get; set; }

		public uint? MFGORDERREQUIRED { get; set; }

		public uint? MINQTY { get; set; }

		public string MINQTYREORDEREMAILGROUPID { get; set; }

		public uint? MINQTYREORDERLIMIT { get; set; }

		public string MODELNUMBER { get; set; }

		public string NOTES { get; set; }

		public string OBJECTCATEGORY { get; set; }

		public string OBJECTTYPE { get; set; }

		public string OUTSOURCETAG { get; set; }

		public uint? PARTTYPE { get; set; }

		public decimal? PLANNEDCOST { get; set; }

		public string PLATFORM { get; set; }

		public string PRODUCTBASEID { get; set; }

		public string PRODUCTCONVERSIONPLANID { get; set; }

		public string PRODUCTFAMILYID { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string PRODUCTTYPEID { get; set; }

		public string PRODUCTVARIATION { get; set; }

		public uint? QTYPERCARTON { get; set; }

		public uint? QTYPERPALLET { get; set; }

		public uint? RECONDITIONLIMIT { get; set; }

		public string SAMPLINGPLANBASEID { get; set; }

		public string SAMPLINGPLANID { get; set; }

		public uint? SERIALCONTROLLED { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public decimal? STDCOST { get; set; }

		public decimal? STDSTARTCHILDQTY { get; set; }

		public decimal? STDSTARTCHILDQTY2 { get; set; }

		public string STDSTARTCUSTOMERID { get; set; }

		public string STDSTARTFACTORYID { get; set; }

		public string STDSTARTLEVELID { get; set; }

		public string STDSTARTOWNERID { get; set; }

		public string STDSTARTPRIORITYCODEID { get; set; }

		public decimal? STDSTARTQTY { get; set; }

		public decimal? STDSTARTQTY2 { get; set; }

		public string STDSTARTREASONID { get; set; }

		public string STDSTARTUOM2ID { get; set; }

		public string STDSTARTUOMID { get; set; }

		public uint? STOCKPOINTCONTROLLED { get; set; }

		public string SUBFACTORY { get; set; }

		public decimal? TARGETCYCLETIME { get; set; }

		public decimal? TARGETDURATIONPERUNIT { get; set; }

		public decimal? TARGETFINALYIELD { get; set; }

		public decimal? TARGETROLLEDTHROUGHPUTYIELD { get; set; }

		public decimal? TARGETUNITSPERHOUR { get; set; }

		public string TCRELEASESTATUS { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string UOM2ID { get; set; }

		public uint? USAGELIMIT { get; set; }

		public uint? USAGELIMIT2 { get; set; }

		public string USERDATACOLLECTIONDEFID { get; set; }

		public decimal? WARNINGEXPIRYDURATION { get; set; }

		public uint? WARNINGLIFETIMELIMIT { get; set; }

		public uint? WARNINGLIFETIMELIMIT2 { get; set; }

		public uint? WARNINGUSAGELIMIT { get; set; }

		public uint? WARNINGUSAGELIMIT2 { get; set; }

		public decimal? WIDTH { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string WORKFLOWBASEID { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
