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
	public partial class RESOURCEDEF {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCAPITALTYPE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETCAPITALTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCATA1", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETCATA1 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCATA2", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETCATA2 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCATA3", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETCATA3 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCATA3DES", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETCATA3DES { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCOSTCENTER", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETCOSTCENTER { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCUSTOMERNAME", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETCUSTOMERNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETCUSTOMEROWNED", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETCUSTOMEROWNED { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDEPT", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETDEPT { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDES", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZASSETDES { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETDES2", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZASSETDES2 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETEFFECTIVEDATE", DbType = "DATE(7)")]
		public DateTime? BIZASSETEFFECTIVEDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETENDLIFEDATE", DbType = "DATE(7)")]
		public DateTime? BIZASSETENDLIFEDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETLOCATION", DbType = "VARCHAR2(1000 BYTE)")]
		public string BIZASSETLOCATION { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER1", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER1 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER2", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER2 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETOWNER3", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETOWNER3 { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETPIC", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZASSETPIC { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETREMARK", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZASSETREMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETSPEC", DbType = "VARCHAR2(100 BYTE)")]
		public string BIZASSETSPEC { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETSTATUS", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETSTATUS { get; set; }

		[JsonProperty, Column(Name = "BIZ_ASSETVENDOR", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZASSETVENDOR { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPOWNERID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPOWNERID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQUIPSTATUSID", DbType = "CHAR(16 BYTE)")]
		public string BIZEQUIPSTATUSID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LIFETIMELIMIT")]
		public uint? BIZLIFETIMELIMIT { get; set; }

		[JsonProperty, Column(Name = "BIZ_LIFETIMEWARNING")]
		public uint? BIZLIFETIMEWARNING { get; set; }

		[JsonProperty, Column(Name = "BIZ_MAXRETURNDAYQTY", DbType = "NUMBER(22)")]
		public decimal? BIZMAXRETURNDAYQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_MESCODE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZMESCODE { get; set; }

		[JsonProperty, Column(Name = "BIZ_PARTQTY")]
		public uint? BIZPARTQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_PHYSICALLOCATIONID", DbType = "CHAR(16 BYTE)")]
		public string BIZPHYSICALLOCATIONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PHYSICALPOSITIONID", DbType = "CHAR(16 BYTE)")]
		public string BIZPHYSICALPOSITIONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SAPASSETCODE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSAPASSETCODE { get; set; }

		[JsonProperty, Column(Name = "BIZ_UOM", DbType = "VARCHAR2(4000 BYTE)")]
		public string BIZUOM { get; set; }

		[JsonProperty, Column(Name = "BIZ_USAGE")]
		public uint? BIZUSAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CIOCHANNELADAPTERID { get; set; }

		[JsonProperty]
		public uint? CLEARANCELEVEL { get; set; }

		[JsonProperty]
		public uint? DECIMALPRECISION { get; set; }

		[JsonProperty]
		public uint? DECIMALSCALE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string DISTRIBUTOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMAILGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "ES_CONNECTTOOMLPRODUCER")]
		public uint? ESCONNECTTOOMLPRODUCER { get; set; }

		[JsonProperty, Column(Name = "ES_DEFECTMESSAGEACTION")]
		public uint? ESDEFECTMESSAGEACTION { get; set; }

		[JsonProperty, Column(Name = "ES_ENABLEMOVEINRETRY")]
		public uint? ESENABLEMOVEINRETRY { get; set; }

		[JsonProperty, Column(Name = "ES_IDEALCPH")]
		public uint? ESIDEALCPH { get; set; }

		[JsonProperty, Column(Name = "ES_MDMGUID", DbType = "VARCHAR2(36 BYTE)")]
		public string ESMDMGUID { get; set; }

		[JsonProperty, Column(Name = "ES_MOVEINERRORACTION")]
		public uint? ESMOVEINERRORACTION { get; set; }

		[JsonProperty, Column(Name = "ES_MOVEINRETRYATTEMPTS")]
		public uint? ESMOVEINRETRYATTEMPTS { get; set; }

		[JsonProperty, Column(Name = "ES_MOVEINRETRYINTERVAL_MS")]
		public uint? ESMOVEINRETRYINTERVALMS { get; set; }

		[JsonProperty, Column(Name = "ES_NUMBEROFLANES")]
		public uint? ESNUMBEROFLANES { get; set; }

		[JsonProperty, Column(Name = "ES_PANELCONFIGURATION")]
		public uint? ESPANELCONFIGURATION { get; set; }

		[JsonProperty, Column(Name = "ES_RESOURCECATEGORYID", DbType = "CHAR(16 BYTE)")]
		public string ESRESOURCECATEGORYID { get; set; }

		[JsonProperty, Column(Name = "ES_RESOURCEINDEX")]
		public uint? ESRESOURCEINDEX { get; set; }

		[JsonProperty, Column(Name = "ES_TOOLPLANDETAILID", DbType = "CHAR(16 BYTE)")]
		public string ESTOOLPLANDETAILID { get; set; }

		[JsonProperty, Column(Name = "ES_USEPRODSTATUSEVENTS")]
		public uint? ESUSEPRODSTATUSEVENTS { get; set; }

		[JsonProperty, Column(Name = "ES_USEQUALITYEVENTS")]
		public uint? ESUSEQUALITYEVENTS { get; set; }

		[JsonProperty, Column(Name = "ES_USETRACEABILITYEVENTS")]
		public uint? ESUSETRACEABILITYEVENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FACTORYID { get; set; }

		[JsonProperty]
		public uint? FACTORYLEVEL { get; set; }

		[JsonProperty]
		public uint? FACTORYLEVELINDEX { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERPLANBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FEEDERSLOTID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(500 BYTE)")]
		public string FULLYQUALIFIEDNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HVSETUPID { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISCAPACITY { get; set; }

		[JsonProperty]
		public uint? ISCONTAINERSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTMAPPINGID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISINCLUDEINOEE { get; set; }

		[JsonProperty]
		public uint? ISLINEIDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISMFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string ISMIOADAPTERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string ISMIOCHANNELSOURCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISMIOCHANNELSRCSERVERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISOEESETTINGSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRECIPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISRESOURCEID { get; set; }

		[JsonProperty]
		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		[JsonProperty]
		public uint? ISSINGLEMFGORDER { get; set; }

		[JsonProperty]
		public uint? ISSINGLEPRODUCT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISSPECID { get; set; }

		[JsonProperty]
		public uint? ISUSEPOSITION { get; set; }

		[JsonProperty]
		public uint? ISUSEPOSITIONSTATE { get; set; }

		[JsonProperty]
		public uint? ISVALIDATEQUEUE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTINTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MAINTENANCECLASSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string NICKNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTCATEGORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTRESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRINTQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTIONSTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string QUANTITY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string RECIPEPATTERN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSMODELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCETYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMARTSCANRULEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTFACTOR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTFACTOR2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string THRUPUTFACTORTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string THRUPUTFACTORTYPE2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty]
		public uint? USEHVTRACEABILITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string VENDORID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string VENDORMODEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string VENDORSERIALNUMBER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WEBSERVICETRANSPORTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WORKINGRANGEMAX { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WORKINGRANGEMIN { get; set; }

	}

}
