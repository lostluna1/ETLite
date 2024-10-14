using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESSETTINGS {

		[JsonProperty, Column(Name = "ES_SETTINGSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESSETTINGSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "ES_AUTOREFRESHTIMEINTERVAL")]
		public uint? ESAUTOREFRESHTIMEINTERVAL { get; set; }

		[JsonProperty, Column(Name = "ES_BOXGRIDCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESBOXGRIDCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_CIVREQUIRECOMPLETION")]
		public uint? ESCIVREQUIRECOMPLETION { get; set; }

		[JsonProperty, Column(Name = "ES_COMBINEPRODUCTREVISIONS")]
		public uint? ESCOMBINEPRODUCTREVISIONS { get; set; }

		[JsonProperty, Column(Name = "ES_COMMANDBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESCOMMANDBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFAULTHOLDREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFAULTHOLDREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFAULTLOSSREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFAULTLOSSREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFAULTQTYADJUSTREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFAULTQTYADJUSTREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFAULTREWORKREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFAULTREWORKREASONID { get; set; }

		[JsonProperty, Column(Name = "ES_DEFECTGRIDCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESDEFECTGRIDCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_DISPLAYBY")]
		public uint? ESDISPLAYBY { get; set; }

		[JsonProperty, Column(Name = "ES_ENFORCEQTY")]
		public uint? ESENFORCEQTY { get; set; }

		[JsonProperty, Column(Name = "ES_INFORMATIONBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESINFORMATIONBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_MAXIMUMROWS")]
		public uint? ESMAXIMUMROWS { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(Name = "ES_PANELCONFIGURATION")]
		public uint? ESPANELCONFIGURATION { get; set; }

		[JsonProperty, Column(Name = "ES_PCBTOOLBARCONFIGID", DbType = "CHAR(16 BYTE)")]
		public string ESPCBTOOLBARCONFIGID { get; set; }

		[JsonProperty, Column(Name = "ES_PREVENTFAILEDCONTAINER")]
		public uint? ESPREVENTFAILEDCONTAINER { get; set; }

		[JsonProperty, Column(Name = "ES_REPORTDISPLAYMODE")]
		public uint? ESREPORTDISPLAYMODE { get; set; }

		[JsonProperty, Column(Name = "ES_REQUIRECOMPLETION")]
		public uint? ESREQUIRECOMPLETION { get; set; }

		[JsonProperty, Column(Name = "ES_ROLLINGTIMEDURATION")]
		public uint? ESROLLINGTIMEDURATION { get; set; }

		[JsonProperty, Column(Name = "ES_ROLLINGTIMEUNIT")]
		public uint? ESROLLINGTIMEUNIT { get; set; }

		[JsonProperty, Column(Name = "ES_SETTINGSNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string ESSETTINGSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_SHOWDPMOREPORT")]
		public uint? ESSHOWDPMOREPORT { get; set; }

		[JsonProperty, Column(Name = "ES_SHOWDPUREPORT")]
		public uint? ESSHOWDPUREPORT { get; set; }

		[JsonProperty, Column(Name = "ES_SHOWPARETOREPORT")]
		public uint? ESSHOWPARETOREPORT { get; set; }

		[JsonProperty, Column(Name = "ES_SHOWYIELDREPORT")]
		public uint? ESSHOWYIELDREPORT { get; set; }

		[JsonProperty, Column(Name = "ES_SUBSTITUTIONREASONID", DbType = "CHAR(16 BYTE)")]
		public string ESSUBSTITUTIONREASONID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

	}

}
