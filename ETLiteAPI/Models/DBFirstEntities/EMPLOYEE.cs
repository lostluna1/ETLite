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
	public partial class EMPLOYEE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string EMPLOYEEID { get; set; }

		[JsonProperty]
		public uint? ALLOWOVERRIDEOFSESSIONVALUES { get; set; }

		[JsonProperty, Column(Name = "BIZ_BU", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBU { get; set; }

		[JsonProperty, Column(Name = "BIZ_DEPTID", DbType = "CHAR(16 BYTE)")]
		public string BIZDEPTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_EMPLOYEEID", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZEMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_SECTION", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZSECTION { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBDEPTID", DbType = "CHAR(16 BYTE)")]
		public string BIZSUBDEPTID { get; set; }

		[JsonProperty]
		public uint? CANLOGIN { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string DOCMANAGERPASSWORD { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DOCMANAGERUSER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DOMAINNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EMAILADDRESS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEELOGININFOID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(Name = "ES_BOXGRIDCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESBOXGRIDCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_COMMANDBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESCOMMANDBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFECTGRIDCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFECTGRIDCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYOPTIONSID", DbType = "CHAR(16 BYTE)")]
		public string ESDISPLAYOPTIONSID { get; set; }

		[JsonProperty, Column(Name = "ES_INFORMATIONBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESINFORMATIONBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_PCBTOOLBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESPCBTOOLBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_TRACKCOMPLETEFAIID", DbType = "CHAR(16 BYTE)")]
		public string ESTRACKCOMPLETEFAIID { get; set; }

		[JsonProperty, Column(Name = "ES_USECONTAINERLIST")]
		public uint? ESUSECONTAINERLIST { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGROLEGROUPID { get; set; }

		[JsonProperty]
		public uint? FILTERTAGACCESS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGSSESSION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FULLNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYVIEWID { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LANGUAGEDICTIONARYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MENUDEFINITIONID { get; set; }

		[JsonProperty]
		public uint? MODELERACCESS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PORTALMENUDEFINITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PORTALMOBILEMENUDEFINITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PORTALV8MENUDEFINITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIMARYORGANIZATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SESSIONVALUESID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TERMINOLOGYDICTIONARYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UIPORTALPROFILEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string USERCOMMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string USERPROFILEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WEBDRILLDOWNMENUDEFINITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WEBMENUDEFINITIONID { get; set; }

	}

}
