using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EMPLOYEE {

		public string EMPLOYEEID { get; set; }

		public uint? ALLOWOVERRIDEOFSESSIONVALUES { get; set; }

		public string BIZ_BU { get; set; }

		public string BIZ_DEPTID { get; set; }

		public string BIZ_EMPLOYEEID { get; set; }

		public string BIZ_SECTION { get; set; }

		public string BIZ_SUBDEPTID { get; set; }

		public uint? CANLOGIN { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSID { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCMANAGERPASSWORD { get; set; }

		public string DOCMANAGERUSER { get; set; }

		public string DOMAINNAME { get; set; }

		public string EMAILADDRESS { get; set; }

		public string EMPLOYEELOGININFOID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_BOXGRIDCONFIGID { get; set; }

		public string ES_COMMANDBARCONFIGID { get; set; }

		public string ES_DEFECTGRIDCONFIGID { get; set; }

		public string ES_DISPLAYOPTIONSID { get; set; }

		public string ES_INFORMATIONBARCONFIGID { get; set; }

		public string ES_PCBTOOLBARCONFIGID { get; set; }

		public string ES_TRACKCOMPLETEFAIID { get; set; }

		public uint? ES_USECONTAINERLIST { get; set; }

		public string ESIGROLEGROUPID { get; set; }

		public uint? FILTERTAGACCESS { get; set; }

		public string FILTERTAGS { get; set; }

		public string FILTERTAGSSESSION { get; set; }

		public string FULLNAME { get; set; }

		public string HISTORYVIEWID { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LANGUAGEDICTIONARYID { get; set; }

		public string MENUDEFINITIONID { get; set; }

		public uint? MODELERACCESS { get; set; }

		public string NOTES { get; set; }

		public string PORTALMENUDEFINITIONID { get; set; }

		public string PORTALMOBILEMENUDEFINITIONID { get; set; }

		public string PORTALV8MENUDEFINITIONID { get; set; }

		public string PRIMARYORGANIZATIONID { get; set; }

		public string SESSIONVALUESID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TERMINOLOGYDICTIONARYID { get; set; }

		public string TRAININGPLANID { get; set; }

		public string UIPORTALPROFILEID { get; set; }

		public string USERCOMMENT { get; set; }

		public string USERPROFILEID { get; set; }

		public string WEBDRILLDOWNMENUDEFINITIONID { get; set; }

		public string WEBMENUDEFINITIONID { get; set; }

	}

}
