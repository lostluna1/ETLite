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
	public partial class FACTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string FACTORYID { get; set; }

		[JsonProperty]
		public uint? ALLOWLINESETTINGSOVERRIDE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEMGTAPPLICATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHILDCONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERAUTOHOLDREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DISPATCHRULEID { get; set; }

		[JsonProperty]
		public uint? DISPLAYGENERALMESSAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ENTERPRISEID { get; set; }

		[JsonProperty, Column(Name = "ES_CHILDSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESCHILDSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_CUSTOMADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESCUSTOMADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFAULTREVISION", DbType = "VARCHAR2(25 BYTE)")]
		public string ESDEFAULTREVISION { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESDISPLAYOPTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_IMEIADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESIMEIADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_MACADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESMACADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_MDMGUID", DbType = "VARCHAR2(36 BYTE)")]
		public string ESMDMGUID { get; set; }

		[JsonProperty, Column(Name = "ES_PARENTSNRULEID", DbType = "CHAR(16 BYTE)")]
		public string ESPARENTSNRULEID { get; set; }

		[JsonProperty, Column(Name = "ES_REQUIRENPIJOB")]
		public uint? ESREQUIRENPIJOB { get; set; }

		[JsonProperty, Column(Name = "ES_SETTINGSID", DbType = "CHAR(16 BYTE)")]
		public string ESSETTINGSID { get; set; }

		[JsonProperty, Column(Name = "ES_UNIQUESERIALNUMBERS")]
		public uint? ESUNIQUESERIALNUMBERS { get; set; }

		[JsonProperty, Column(Name = "ES_USECONTAINERLIST")]
		public uint? ESUSECONTAINERLIST { get; set; }

		[JsonProperty, Column(Name = "ES_USECONTAINERNAMEFORSN")]
		public uint? ESUSECONTAINERNAMEFORSN { get; set; }

		[JsonProperty]
		public uint? FACTORYLEVELINDEX { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string GENERALMESSAGE { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISAUTOSTARTSETTINGSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCARRIERCONTAINERLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCARRIERNUMBERINGRULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCARRIEROWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCARRIERSTARTREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISCARRIERWORKFLOWID { get; set; }

		[JsonProperty]
		public uint? ISCHANGEJOBSTATUSAUTOMATICALLY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTINVENTORYLOCATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTISSUEDIFFREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTREMOVALREASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFAULTREPLACEREASONID { get; set; }

		[JsonProperty]
		public uint? ISDISABLEREPORTINGSUMMARY { get; set; }

		[JsonProperty]
		public uint? ISENABLECARRIERTRACKING { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISJOBSCHEDULESTATUSMODELID { get; set; }

		[JsonProperty]
		public uint? ISLOCALSCHEDULINGENABLED { get; set; }

		[JsonProperty]
		public uint? ISMATERIALMANAGEENABLED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISOEESETTINGSID { get; set; }

		[JsonProperty]
		public uint? ISPREACTORENABLED { get; set; }

		[JsonProperty]
		public uint? ISRECORDALLSTEPS { get; set; }

		[JsonProperty]
		public uint? ISREUSETRACKINGCONTAINER { get; set; }

		[JsonProperty]
		public uint? ISVALIDATEMATERIALQUEUEQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? MAXTIMESINCEMSGSRETRIEVED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGCALENDARID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORGANIZATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARTREQUESTEMAILGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRINTQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string RECIPEPATTERN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string REPORTHEADING { get; set; }

		[JsonProperty]
		public uint? REPRINTREASONREQUIRED { get; set; }

		[JsonProperty]
		public uint? REQUIRELOCATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCESTATUSMODELID { get; set; }

		[JsonProperty]
		public uint? RETENTIONDAYS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHOPFLOORSETTINGSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMARTSCANRULEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SMTPTRANSPORTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string XMLPASSWORD { get; set; }

		[JsonProperty]
		public uint? XMLPORT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string XMLSERVERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string XMLUSERNAME { get; set; }

	}

}
