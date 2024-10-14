using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCEDEF {

		public string RESOURCEID { get; set; }

		public string BIZ_ASSETCAPITALTYPE { get; set; }

		public string BIZ_ASSETCATA1 { get; set; }

		public string BIZ_ASSETCATA2 { get; set; }

		public string BIZ_ASSETCATA3 { get; set; }

		public string BIZ_ASSETCATA3DES { get; set; }

		public string BIZ_ASSETCOSTCENTER { get; set; }

		public string BIZ_ASSETCUSTOMERNAME { get; set; }

		public string BIZ_ASSETCUSTOMEROWNED { get; set; }

		public string BIZ_ASSETDEPT { get; set; }

		public string BIZ_ASSETDES { get; set; }

		public string BIZ_ASSETDES2 { get; set; }

		public DateTime? BIZ_ASSETEFFECTIVEDATE { get; set; }

		public DateTime? BIZ_ASSETENDLIFEDATE { get; set; }

		public string BIZ_ASSETLOCATION { get; set; }

		public string BIZ_ASSETOWNER1 { get; set; }

		public string BIZ_ASSETOWNER2 { get; set; }

		public string BIZ_ASSETOWNER3 { get; set; }

		public string BIZ_ASSETPIC { get; set; }

		public string BIZ_ASSETREMARK { get; set; }

		public string BIZ_ASSETSPEC { get; set; }

		public string BIZ_ASSETSTATUS { get; set; }

		public string BIZ_ASSETVENDOR { get; set; }

		public string BIZ_EQUIPOWNERID { get; set; }

		public string BIZ_EQUIPSTATUSID { get; set; }

		public uint? BIZ_LIFETIMELIMIT { get; set; }

		public uint? BIZ_LIFETIMEWARNING { get; set; }

		public decimal? BIZ_MAXRETURNDAYQTY { get; set; }

		public string BIZ_MESCODE { get; set; }

		public uint? BIZ_PARTQTY { get; set; }

		public string BIZ_PHYSICALLOCATIONID { get; set; }

		public string BIZ_PHYSICALPOSITIONID { get; set; }

		public string BIZ_SAPASSETCODE { get; set; }

		public string BIZ_UOM { get; set; }

		public uint? BIZ_USAGE { get; set; }

		public string BOMBASEID { get; set; }

		public string BOMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string CIOCHANNELADAPTERID { get; set; }

		public uint? CLEARANCELEVEL { get; set; }

		public uint? DECIMALPRECISION { get; set; }

		public uint? DECIMALSCALE { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISTRIBUTOR { get; set; }

		public string EMAILGROUPID { get; set; }

		public string EMPLOYEEID { get; set; }

		public uint? ES_CONNECTTOOMLPRODUCER { get; set; }

		public uint? ES_DEFECTMESSAGEACTION { get; set; }

		public uint? ES_ENABLEMOVEINRETRY { get; set; }

		public uint? ES_IDEALCPH { get; set; }

		public string ES_MDMGUID { get; set; }

		public uint? ES_MOVEINERRORACTION { get; set; }

		public uint? ES_MOVEINRETRYATTEMPTS { get; set; }

		public uint? ES_MOVEINRETRYINTERVAL_MS { get; set; }

		public uint? ES_NUMBEROFLANES { get; set; }

		public uint? ES_PANELCONFIGURATION { get; set; }

		public string ES_RESOURCECATEGORYID { get; set; }

		public uint? ES_RESOURCEINDEX { get; set; }

		public string ES_TOOLPLANDETAILID { get; set; }

		public uint? ES_USEPRODSTATUSEVENTS { get; set; }

		public uint? ES_USEQUALITYEVENTS { get; set; }

		public uint? ES_USETRACEABILITYEVENTS { get; set; }

		public string FACTORYID { get; set; }

		public uint? FACTORYLEVEL { get; set; }

		public uint? FACTORYLEVELINDEX { get; set; }

		public string FEEDERCONTAINERID { get; set; }

		public string FEEDERPLANBASEID { get; set; }

		public string FEEDERPLANID { get; set; }

		public string FEEDERSLOTID { get; set; }

		public string FILTERTAGS { get; set; }

		public string FULLYQUALIFIEDNAME { get; set; }

		public string HVSETUPID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISCAPACITY { get; set; }

		public uint? ISCONTAINERSTATUS { get; set; }

		public string ISDEFECTMAPPINGID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISINCLUDEINOEE { get; set; }

		public uint? ISLINEIDENTIFIER { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISMIOADAPTERNAME { get; set; }

		public string ISMIOCHANNELSOURCE { get; set; }

		public string ISMIOCHANNELSRCSERVERNAME { get; set; }

		public string ISOEESETTINGSID { get; set; }

		public string ISPRODUCTID { get; set; }

		public string ISRECIPEBASEID { get; set; }

		public string ISRECIPEID { get; set; }

		public string ISRESOURCEID { get; set; }

		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		public uint? ISSINGLEMFGORDER { get; set; }

		public uint? ISSINGLEPRODUCT { get; set; }

		public string ISSPECID { get; set; }

		public uint? ISUSEPOSITION { get; set; }

		public uint? ISUSEPOSITIONSTATE { get; set; }

		public uint? ISVALIDATEQUEUE { get; set; }

		public string LASTINTEGRATIONTXNID { get; set; }

		public string LASTREVTXNID { get; set; }

		public string LOCATIONID { get; set; }

		public string MAINTENANCECLASSID { get; set; }

		public string NICKNAME { get; set; }

		public string NOTES { get; set; }

		public string OBJECTCATEGORY { get; set; }

		public string OBJECTTYPE { get; set; }

		public string PARENTRESOURCEID { get; set; }

		public string PRINTQUEUEID { get; set; }

		public string PRODUCTIONSTATUSID { get; set; }

		public string QUANTITY { get; set; }

		public string RECIPEPATTERN { get; set; }

		public string RESOURCEFAMILYID { get; set; }

		public string RESOURCENAME { get; set; }

		public string RESOURCESTATUSMODELID { get; set; }

		public string RESOURCETYPEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SMARTSCANRULEID { get; set; }

		public decimal? THRUPUTFACTOR { get; set; }

		public decimal? THRUPUTFACTOR2 { get; set; }

		public string THRUPUTFACTORTYPE { get; set; }

		public string THRUPUTFACTORTYPE2 { get; set; }

		public string TOOLPLANID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string UOMID { get; set; }

		public uint? USEHVTRACEABILITY { get; set; }

		public string VENDORID { get; set; }

		public string VENDORMODEL { get; set; }

		public string VENDORSERIALNUMBER { get; set; }

		public string WEBSERVICETRANSPORTID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public decimal? WORKINGRANGEMAX { get; set; }

		public decimal? WORKINGRANGEMIN { get; set; }

	}

}
