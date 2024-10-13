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
	public partial class SPEC {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? ALLOWOVERRIDES { get; set; }

		[JsonProperty]
		public uint? ALLOWREPROCESS { get; set; }

		[JsonProperty]
		public uint? ALLOWREWORKTO { get; set; }

		[JsonProperty]
		public uint? AUTOCLOSE { get; set; }

		[JsonProperty]
		public uint? AUTOCOMPONENTISSUE { get; set; }

		[JsonProperty]
		public uint? AUTODISASSOCIATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_AUTOMOVE")]
		public uint? BIZAUTOMOVE { get; set; }

		[JsonProperty, Column(Name = "BIZ_CHECKLABLE")]
		public uint? BIZCHECKLABLE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISPACKING")]
		public uint? BIZISPACKING { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISREPAIR")]
		public uint? BIZISREPAIR { get; set; }

		[JsonProperty, Column(Name = "BIZ_ISTEST")]
		public uint? BIZISTEST { get; set; }

		[JsonProperty, Column(Name = "BIZ_PKN")]
		public uint? BIZPKN { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRINTINGLABLE")]
		public uint? BIZPRINTINGLABLE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPUTERGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DEFAULTISSUEDIFFERENCEREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DEFAULTSUBSTITUTIONREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ELECTRONICPROCEDUREBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ELECTRONICPROCEDUREID { get; set; }

		[JsonProperty, Column(Name = "ES_ASSIGNPHYSICALADDRESS")]
		public uint? ESASSIGNPHYSICALADDRESS { get; set; }

		[JsonProperty, Column(Name = "ES_AUTOISSUETOPANEL")]
		public uint? ESAUTOISSUETOPANEL { get; set; }

		[JsonProperty, Column(Name = "ES_AUTOOPENINSTRUCTIONS")]
		public uint? ESAUTOOPENINSTRUCTIONS { get; set; }

		[JsonProperty, Column(Name = "ES_CLEARDEFECTSACTION")]
		public uint? ESCLEARDEFECTSACTION { get; set; }

		[JsonProperty, Column(Name = "ES_CLEAROPENDEFECTS")]
		public uint? ESCLEAROPENDEFECTS { get; set; }

		[JsonProperty, Column(Name = "ES_CLOSEPARENTCONTAINERS")]
		public uint? ESCLOSEPARENTCONTAINERS { get; set; }

		[JsonProperty, Column(Name = "ES_CONTAINERACTION")]
		public uint? ESCONTAINERACTION { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESDISPLAYOPTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_FIRSTARTICLEMODE")]
		public uint? ESFIRSTARTICLEMODE { get; set; }

		[JsonProperty, Column(Name = "ES_FIRSTARTICLETRACKINGMODE")]
		public uint? ESFIRSTARTICLETRACKINGMODE { get; set; }

		[JsonProperty, Column(Name = "ES_GUIDEDMANUALASSEMBLY")]
		public uint? ESGUIDEDMANUALASSEMBLY { get; set; }

		[JsonProperty, Column(Name = "ES_ITERATIONLIMIT")]
		public uint? ESITERATIONLIMIT { get; set; }

		[JsonProperty, Column(Name = "ES_ITERATIONLIMITFAILACTION")]
		public uint? ESITERATIONLIMITFAILACTION { get; set; }

		[JsonProperty, Column(Name = "ES_ITERATIONLIMITHOLDREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESITERATIONLIMITHOLDREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_ITERATIONLIMITLOSSREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESITERATIONLIMITLOSSREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_ITERATIONLIMITSENABLED")]
		public uint? ESITERATIONLIMITSENABLED { get; set; }

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANID", DbType = "CHAR(16 BYTE)")]
		public string ESMFGORDERREASSIGNPLANID { get; set; }

		[JsonProperty, Column(Name = "ES_PERFORMMFGORDERREASSIGNPC")]
		public uint? ESPERFORMMFGORDERREASSIGNPC { get; set; }

		[JsonProperty, Column(Name = "ES_RESETMATERIALEXPOSURE")]
		public uint? ESRESETMATERIALEXPOSURE { get; set; }

		[JsonProperty, Column(Name = "ES_SIDE", DbType = "VARCHAR2(40 BYTE)")]
		public string ESSIDE { get; set; }

		[JsonProperty, Column(Name = "ES_VERIFYPHYSICALADDRESSES")]
		public uint? ESVERIFYPHYSICALADDRESSES { get; set; }

		[JsonProperty, Column(Name = "ES_VERIFYTOOLPLAN")]
		public uint? ESVERIFYTOOLPLAN { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISCARRIERAUTOMODE { get; set; }

		[JsonProperty]
		public uint? ISDISABLEEPROCVALIDATION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLOADCARRIER { get; set; }

		[JsonProperty]
		public uint? ISMATERIALISSUE { get; set; }

		[JsonProperty]
		public uint? ISMATERIALRETURN { get; set; }

		[JsonProperty]
		public uint? ISMATERIALWITHDRAW { get; set; }

		[JsonProperty]
		public uint? ISREQUIRESRESOURCE { get; set; }

		[JsonProperty]
		public uint? ISUNLOADCARRIER { get; set; }

		[JsonProperty]
		public uint? ISVERIFYRECIPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MAXQUEUETIME { get; set; }

		[JsonProperty]
		public uint? MAXQUEUETIMEACTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OPERATIONID { get; set; }

		[JsonProperty]
		public uint? POSTPRODUCTIONACTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTCONVERSIONREQUIREMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPEFILEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPEFILEID { get; set; }

		[JsonProperty]
		public uint? RECORDTDADETAILSHISTORY { get; set; }

		[JsonProperty]
		public uint? REQUIREPREPRODUCTIONPROCEDURE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCHEDULINGDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string SPECREVISION { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty]
		public uint? TESTSNO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string THRUPUTREQUIREMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty]
		public uint? VALIDATELOTSAMPLINGCOMPLETE { get; set; }

		[JsonProperty]
		public uint? VALIDATEMATERIALCONSUMPTION { get; set; }

		[JsonProperty]
		public uint? VERIFYMFGLINE { get; set; }

		[JsonProperty]
		public uint? VERIFYYIELDLIMITS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WARNINGQUEUETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
