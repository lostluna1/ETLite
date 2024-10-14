using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPEC {

		public string SPECID { get; set; }

		public uint? ALLOWOVERRIDES { get; set; }

		public uint? ALLOWREPROCESS { get; set; }

		public uint? ALLOWREWORKTO { get; set; }

		public uint? AUTOCLOSE { get; set; }

		public uint? AUTOCOMPONENTISSUE { get; set; }

		public uint? AUTODISASSOCIATE { get; set; }

		public uint? BIZ_AUTOMOVE { get; set; }

		public uint? BIZ_CHECKLABLE { get; set; }

		public uint? BIZ_ISPACKING { get; set; }

		public uint? BIZ_ISREPAIR { get; set; }

		public uint? BIZ_ISTEST { get; set; }

		public uint? BIZ_PKN { get; set; }

		public uint? BIZ_PRINTINGLABLE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COMPUTERGROUPID { get; set; }

		public string DEFAULTISSUEDIFFERENCEREASONID { get; set; }

		public string DEFAULTSUBSTITUTIONREASONID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string ECO { get; set; }

		public string ELECTRONICPROCEDUREBASEID { get; set; }

		public string ELECTRONICPROCEDUREID { get; set; }

		public uint? ES_ASSIGNPHYSICALADDRESS { get; set; }

		public uint? ES_AUTOISSUETOPANEL { get; set; }

		public uint? ES_AUTOOPENINSTRUCTIONS { get; set; }

		public uint? ES_CLEARDEFECTSACTION { get; set; }

		public uint? ES_CLEAROPENDEFECTS { get; set; }

		public uint? ES_CLOSEPARENTCONTAINERS { get; set; }

		public uint? ES_CONTAINERACTION { get; set; }

		public string ES_DISPLAYOPTIONSID { get; set; }

		public uint? ES_FIRSTARTICLEMODE { get; set; }

		public uint? ES_FIRSTARTICLETRACKINGMODE { get; set; }

		public uint? ES_GUIDEDMANUALASSEMBLY { get; set; }

		public uint? ES_ITERATIONLIMIT { get; set; }

		public uint? ES_ITERATIONLIMITFAILACTION { get; set; }

		public string ES_ITERATIONLIMITHOLDREASONID { get; set; }

		public string ES_ITERATIONLIMITLOSSREASONID { get; set; }

		public uint? ES_ITERATIONLIMITSENABLED { get; set; }

		public string ES_MFGORDERREASSIGNPLANID { get; set; }

		public uint? ES_PERFORMMFGORDERREASSIGNPC { get; set; }

		public uint? ES_RESETMATERIALEXPOSURE { get; set; }

		public string ES_SIDE { get; set; }

		public uint? ES_VERIFYPHYSICALADDRESSES { get; set; }

		public uint? ES_VERIFYTOOLPLAN { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISCARRIERAUTOMODE { get; set; }

		public uint? ISDISABLEEPROCVALIDATION { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLOADCARRIER { get; set; }

		public uint? ISMATERIALISSUE { get; set; }

		public uint? ISMATERIALRETURN { get; set; }

		public uint? ISMATERIALWITHDRAW { get; set; }

		public uint? ISREQUIRESRESOURCE { get; set; }

		public uint? ISUNLOADCARRIER { get; set; }

		public uint? ISVERIFYRECIPE { get; set; }

		public decimal? MAXQUEUETIME { get; set; }

		public uint? MAXQUEUETIMEACTION { get; set; }

		public string MFGLINEID { get; set; }

		public string NOTES { get; set; }

		public string OPERATIONID { get; set; }

		public uint? POSTPRODUCTIONACTION { get; set; }

		public string PRODUCTCONVERSIONREQUIREMENT { get; set; }

		public string RECIPEFILEBASEID { get; set; }

		public string RECIPEFILEID { get; set; }

		public uint? RECORDTDADETAILSHISTORY { get; set; }

		public uint? REQUIREPREPRODUCTIONPROCEDURE { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string SCHEDULINGDETAILID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SETUPBASEID { get; set; }

		public string SETUPID { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECREVISION { get; set; }

		public uint? STATUS { get; set; }

		public uint? TESTSNO { get; set; }

		public string THRUPUTREQUIREMENT { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public uint? VALIDATELOTSAMPLINGCOMPLETE { get; set; }

		public uint? VALIDATEMATERIALCONSUMPTION { get; set; }

		public uint? VERIFYMFGLINE { get; set; }

		public uint? VERIFYYIELDLIMITS { get; set; }

		public decimal? WARNINGQUEUETIME { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
