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
	public partial class PRODUCT {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLOFPROCESSBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLOFPROCESSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ACTIVETIME", DbType = "NUMBER(22)")]
		public decimal? BIZACTIVETIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSEMBLYSCRAPRATE", DbType = "NUMBER(22)")]
		public decimal? BIZASSEMBLYSCRAPRATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZATUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)")]
		public string BIZBUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EXTPRODUCT", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZEXTPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_EXTPURCHASEWHID", DbType = "CHAR(16 BYTE)")]
		public string BIZEXTPURCHASEWHID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZFAIPLANID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIQTY")]
		public uint? BIZFAIQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZFQCPLANID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCTYPE")]
		public uint? BIZFQCTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_GROSSWEIGHT", DbType = "NUMBER(22)")]
		public decimal? BIZGROSSWEIGHT { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZIPQCPLANID { get; set; }

		[JsonProperty, Column(Name = "BIZ_IPQCQTY")]
		public uint? BIZIPQCQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISMOPCBARULE")]
		public uint? BIZISMOPCBARULE { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABELPRINTSETUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABELPRINTSETUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABLECHECKPLANID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAIPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZLAIPLANID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAIQTY")]
		public uint? BIZLAIQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATERIALFAMILYID", DbType = "CHAR(16 BYTE)")]
		public string BIZMATERIALFAMILYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATERIALLT")]
		public uint? BIZMATERIALLT { get; set; }

		[JsonProperty, Column(Name = "BIZ_MRPCONTROLLER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZMRPCONTROLLER { get; set; }

		[JsonProperty, Column(Name = "BIZ_MULTIPLANTMATLSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZMULTIPLANTMATLSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_MULTPSTATUSEFFSTARTDATE", DbType = "DATE(7)")]
		public DateTime? BIZMULTPSTATUSEFFSTARTDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_NETUOMID", DbType = "CHAR(16 BYTE)")]
		public string BIZNETUOMID { get; set; }

		[JsonProperty, Column(Name = "BIZ_NETWEIGHT", DbType = "NUMBER(22)")]
		public decimal? BIZNETWEIGHT { get; set; }

		[JsonProperty, Column(Name = "BIZ_PACKINGQTY", DbType = "NUMBER(22)")]
		public decimal? BIZPACKINGQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_PCBASN", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZPCBASN { get; set; }

		[JsonProperty, Column(Name = "BIZ_POTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZPOTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRCGROUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRCGROUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTIONWHID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTIONWHID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKGROUID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKGROUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAFESTOCKQTY", DbType = "NUMBER(22)")]
		public decimal? BIZSAFESTOCKQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAMPLINGMEASUREQTY")]
		public uint? BIZSAMPLINGMEASUREQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SCRAPRATE", DbType = "NUMBER(22)")]
		public decimal? BIZSCRAPRATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SELFPRODUCTIONDAY")]
		public uint? BIZSELFPRODUCTIONDAY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SINGLEPLANTMATLSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZSINGLEPLANTMATLSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SINGLEPSTATUSEFFSTARTDATE", DbType = "DATE(7)")]
		public DateTime? BIZSINGLEPSTATUSEFFSTARTDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SPECIALPOTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZSPECIALPOTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_STDCOSTPRICE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSTDCOSTPRICE { get; set; }

		[JsonProperty, Column(Name = "BIZ_STOCKQTY")]
		public uint? BIZSTOCKQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_STORAGELOCATION", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSTORAGELOCATION { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUPPLYTYPE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSUPPLYTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BRANDNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CATALOGNUMBER { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CONCOMITANTPRODUCTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CURRENTCOST { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERPART { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CUSTOMERPRODUCTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEVICETYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ERPPRODUCTFAMILY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEID { get; set; }

		[JsonProperty, Column(Name = "ES_BOMBASEID", DbType = "CHAR(16 BYTE)")]
		public string ESBOMBASEID { get; set; }

		[JsonProperty, Column(Name = "ES_BOMID", DbType = "CHAR(16 BYTE)")]
		public string ESBOMID { get; set; }

		[JsonProperty, Column(Name = "ES_CADINSTRUCTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESCADINSTRUCTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_CHILDSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESCHILDSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_CONTAINERACTION")]
		public uint? ESCONTAINERACTION { get; set; }

		[JsonProperty, Column(Name = "ES_CUSTOMADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESCUSTOMADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_CUSTOMADDRESSQTY")]
		public uint? ESCUSTOMADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_EFFECTIVEENDDATE", DbType = "DATE(7)")]
		public DateTime? ESEFFECTIVEENDDATE { get; set; }

		[JsonProperty, Column(Name = "ES_EFFECTIVEENDDATEGMT", DbType = "DATE(7)")]
		public DateTime? ESEFFECTIVEENDDATEGMT { get; set; }

		[JsonProperty, Column(Name = "ES_EFFECTIVESTARTDATE", DbType = "DATE(7)")]
		public DateTime? ESEFFECTIVESTARTDATE { get; set; }

		[JsonProperty, Column(Name = "ES_EFFECTIVESTARTDATEGMT", DbType = "DATE(7)")]
		public DateTime? ESEFFECTIVESTARTDATEGMT { get; set; }

		[JsonProperty, Column(Name = "ES_IMEIADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESIMEIADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_IMEIADDRESSQTY")]
		public uint? ESIMEIADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_MACADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESMACADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_MACADDRESSQTY")]
		public uint? ESMACADDRESSQTY { get; set; }

		[JsonProperty, Column(Name = "ES_MASTERRECIPE", DbType = "VARCHAR2(30 BYTE)")]
		public string ESMASTERRECIPE { get; set; }

		[JsonProperty, Column(Name = "ES_MATERIALATTRIBUTES", DbType = "VARCHAR2(30 BYTE)")]
		public string ESMATERIALATTRIBUTES { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBBASEID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBBASEID { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty, Column(Name = "ES_PARENTSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESPARENTSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_PINCOUNT")]
		public uint? ESPINCOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_POLARIZED")]
		public uint? ESPOLARIZED { get; set; }

		[JsonProperty, Column(Name = "ES_PRODUCTIONBOMBASEID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODUCTIONBOMBASEID { get; set; }

		[JsonProperty, Column(Name = "ES_PRODUCTIONBOMID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODUCTIONBOMID { get; set; }

		[JsonProperty, Column(Name = "ES_RESETREWORKTOTALCOUNT")]
		public uint? ESRESETREWORKTOTALCOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_REWORKCYCLECHECK")]
		public uint? ESREWORKCYCLECHECK { get; set; }

		[JsonProperty, Column(Name = "ES_REWORKCYCLELIMIT")]
		public uint? ESREWORKCYCLELIMIT { get; set; }

		[JsonProperty, Column(Name = "ES_REWORKHOLDREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESREWORKHOLDREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_REWORKLOSSREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESREWORKLOSSREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_SCHEMATICID", DbType = "CHAR(16 BYTE)")]
		public string ESSCHEMATICID { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERCONFIG")]
		public uint? ESSERIALNUMBERCONFIG { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERGENERATION")]
		public uint? ESSERIALNUMBERGENERATION { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERPREFIX", DbType = "VARCHAR2(30 BYTE)")]
		public string ESSERIALNUMBERPREFIX { get; set; }

		[JsonProperty, Column(Name = "ES_SERIALNUMBERQTY")]
		public uint? ESSERIALNUMBERQTY { get; set; }

		[JsonProperty, Column(Name = "ES_STARTVIRTUALSN")]
		public uint? ESSTARTVIRTUALSN { get; set; }

		[JsonProperty, Column(Name = "ES_STDSTARTCHILDLEVELID", DbType = "CHAR(16 BYTE)")]
		public string ESSTDSTARTCHILDLEVELID { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANMATRIXID", DbType = "CHAR(16 BYTE)")]
		public string ESTOOLPLANMATRIXID { get; set; }

		[JsonProperty, Column(Name = "ES_UNIQUESERIALNUMBERS")]
		public uint? ESUNIQUESERIALNUMBERS { get; set; }

		[JsonProperty, Column(Name = "ES_USECONTAINERNAMEFORSN")]
		public uint? ESUSECONTAINERNAMEFORSN { get; set; }

		[JsonProperty]
		public uint? EXTERNALLYCONTROLLED { get; set; }

		[JsonProperty]
		public uint? FEFOENFORCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEFOOVERRIDEESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string FREQUENCY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string GLENTITY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? HEIGHT { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? INSPECTALL { get; set; }

		[JsonProperty]
		public uint? INVENTORYCONTROLLED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISIMAGEID { get; set; }

		[JsonProperty]
		public uint? ISPHANTOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEPLANID { get; set; }

		[JsonProperty]
		public uint? ISREGISTERCONTAINERS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LENGTH { get; set; }

		[JsonProperty]
		public uint? LIFETIMELIMIT { get; set; }

		[JsonProperty]
		public uint? LIFETIMELIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LIMITSEMAILGROUPID { get; set; }

		[JsonProperty]
		public uint? LOTCONTROLLED { get; set; }

		[JsonProperty]
		public uint? MATERIALACCUMULATEEXPOSURE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MATERIALCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MATERIALEXPOSUREDURATION { get; set; }

		[JsonProperty]
		public uint? MATERIALMAXRETURNS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MATERIALTHAWINGDURATION { get; set; }

		[JsonProperty]
		public uint? MAXQTY { get; set; }

		[JsonProperty]
		public uint? MFGORDERREQUIRED { get; set; }

		[JsonProperty]
		public uint? MINQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MINQTYREORDEREMAILGROUPID { get; set; }

		[JsonProperty]
		public uint? MINQTYREORDERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MODELNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OUTSOURCETAG { get; set; }

		[JsonProperty]
		public uint? PARTTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANNEDCOST { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PLATFORM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTCONVERSIONPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTTYPEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string PRODUCTVARIATION { get; set; }

		[JsonProperty]
		public uint? QTYPERCARTON { get; set; }

		[JsonProperty]
		public uint? QTYPERPALLET { get; set; }

		[JsonProperty]
		public uint? RECONDITIONLIMIT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SAMPLINGPLANID { get; set; }

		[JsonProperty]
		public uint? SERIALCONTROLLED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDCOST { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTCHILDQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTCHILDQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTCUSTOMERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTFACTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTOWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTPRIORITYCODEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDSTARTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTUOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STDSTARTUOMID { get; set; }

		[JsonProperty]
		public uint? STOCKPOINTCONTROLLED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SUBFACTORY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETCYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETDURATIONPERUNIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETFINALYIELD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETROLLEDTHROUGHPUTYIELD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TARGETUNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string TCRELEASESTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty]
		public uint? USAGELIMIT { get; set; }

		[JsonProperty]
		public uint? USAGELIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string USERDATACOLLECTIONDEFID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WARNINGEXPIRYDURATION { get; set; }

		[JsonProperty]
		public uint? WARNINGLIFETIMELIMIT { get; set; }

		[JsonProperty]
		public uint? WARNINGLIFETIMELIMIT2 { get; set; }

		[JsonProperty]
		public uint? WARNINGUSAGELIMIT { get; set; }

		[JsonProperty]
		public uint? WARNINGUSAGELIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WIDTH { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

	}

}
