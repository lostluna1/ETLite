using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_SETTINGS {

		public string ES_SETTINGSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ES_AUTOREFRESHTIMEINTERVAL { get; set; }

		public string ES_BOXGRIDCONFIGID { get; set; }

		public uint? ES_CIVREQUIRECOMPLETION { get; set; }

		public uint? ES_COMBINEPRODUCTREVISIONS { get; set; }

		public string ES_COMMANDBARCONFIGID { get; set; }

		public string ES_DEFAULTHOLDREASONID { get; set; }

		public string ES_DEFAULTLOSSREASONID { get; set; }

		public string ES_DEFAULTQTYADJUSTREASONID { get; set; }

		public string ES_DEFAULTREWORKREASONID { get; set; }

		public string ES_DEFECTGRIDCONFIGID { get; set; }

		public uint? ES_DISPLAYBY { get; set; }

		public uint? ES_ENFORCEQTY { get; set; }

		public string ES_INFORMATIONBARCONFIGID { get; set; }

		public uint? ES_MAXIMUMROWS { get; set; }

		public uint? ES_MOUNTINGTECHNOLOGY { get; set; }

		public uint? ES_PANELCONFIGURATION { get; set; }

		public string ES_PCBTOOLBARCONFIGID { get; set; }

		public uint? ES_PREVENTFAILEDCONTAINER { get; set; }

		public uint? ES_REPORTDISPLAYMODE { get; set; }

		public uint? ES_REQUIRECOMPLETION { get; set; }

		public uint? ES_ROLLINGTIMEDURATION { get; set; }

		public uint? ES_ROLLINGTIMEUNIT { get; set; }

		public string ES_SETTINGSNAME { get; set; }

		public uint? ES_SHOWDPMOREPORT { get; set; }

		public uint? ES_SHOWDPUREPORT { get; set; }

		public uint? ES_SHOWPARETOREPORT { get; set; }

		public uint? ES_SHOWYIELDREPORT { get; set; }

		public string ES_SUBSTITUTIONREASONID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
