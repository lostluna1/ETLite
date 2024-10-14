using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FACTORY {

		public string FACTORYID { get; set; }

		public uint? ALLOWLINESETTINGSOVERRIDE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEMGTAPPLICATIONID { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		public string CONTAINERAUTOHOLDREASONID { get; set; }

		public string CONTAINERNUMBERINGRULEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISPATCHRULEID { get; set; }

		public uint? DISPLAYGENERALMESSAGE { get; set; }

		public string ENTERPRISEID { get; set; }

		public string ES_CHILDSNRULEID { get; set; }

		public string ES_CUSTOMADDRESSPOOLID { get; set; }

		public string ES_DEFAULTREVISION { get; set; }

		public string ES_DISPLAYOPTIONSID { get; set; }

		public string ES_IMEIADDRESSPOOLID { get; set; }

		public string ES_MACADDRESSPOOLID { get; set; }

		public string ES_MDMGUID { get; set; }

		public string ES_PARENTSNRULEID { get; set; }

		public uint? ES_REQUIRENPIJOB { get; set; }

		public string ES_SETTINGSID { get; set; }

		public uint? ES_UNIQUESERIALNUMBERS { get; set; }

		public uint? ES_USECONTAINERLIST { get; set; }

		public uint? ES_USECONTAINERNAMEFORSN { get; set; }

		public uint? FACTORYLEVELINDEX { get; set; }

		public string FACTORYNAME { get; set; }

		public string FILTERTAGS { get; set; }

		public string GENERALMESSAGE { get; set; }

		public uint? ICONID { get; set; }

		public string ISAUTOSTARTSETTINGSID { get; set; }

		public string ISCARRIERCONTAINERLEVELID { get; set; }

		public string ISCARRIERNUMBERINGRULEID { get; set; }

		public string ISCARRIEROWNERID { get; set; }

		public string ISCARRIERSTARTREASONID { get; set; }

		public string ISCARRIERWORKFLOWID { get; set; }

		public uint? ISCHANGEJOBSTATUSAUTOMATICALLY { get; set; }

		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		public string ISDEFAULTISSUEDIFFREASONID { get; set; }

		public string ISDEFAULTREMOVALREASONID { get; set; }

		public string ISDEFAULTREPLACEREASONID { get; set; }

		public uint? ISDISABLEREPORTINGSUMMARY { get; set; }

		public uint? ISENABLECARRIERTRACKING { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISJOBSCHEDULESTATUSMODELID { get; set; }

		public uint? ISLOCALSCHEDULINGENABLED { get; set; }

		public uint? ISMATERIALMANAGEENABLED { get; set; }

		public string ISOEESETTINGSID { get; set; }

		public uint? ISPREACTORENABLED { get; set; }

		public uint? ISRECORDALLSTEPS { get; set; }

		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		public uint? ISVALIDATEMATERIALQUEUEQTY { get; set; }

		public decimal? MAXTIMESINCEMSGSRETRIEVED { get; set; }

		public string MFGCALENDARID { get; set; }

		public string NOTES { get; set; }

		public string ORGANIZATIONID { get; set; }

		public string PARTREQUESTEMAILGROUPID { get; set; }

		public string PRINTQUEUEID { get; set; }

		public string RECIPEPATTERN { get; set; }

		public string REPORTHEADING { get; set; }

		public uint? REPRINTREASONREQUIRED { get; set; }

		public uint? REQUIRELOCATION { get; set; }

		public string RESOURCESTATUSMODELID { get; set; }

		public uint? RETENTIONDAYS { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SHOPFLOORSETTINGSID { get; set; }

		public string SMARTSCANRULEID { get; set; }

		public string SMTPTRANSPORTID { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

		public string XMLPASSWORD { get; set; }

		public uint? XMLPORT { get; set; }

		public string XMLSERVERNAME { get; set; }

		public string XMLUSERNAME { get; set; }

	}

}
