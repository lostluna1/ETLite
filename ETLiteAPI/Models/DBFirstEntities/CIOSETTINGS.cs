using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSETTINGS {

		public string CIOSETTINGSID { get; set; }

		public string BROKERSERVICEENDPOINTS { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? CHECKCONFIGINTERVAL { get; set; }

		public string CIOCAMSTARCONNECTIONID { get; set; }

		public string CIOSETTINGSNAME { get; set; }

		public uint? CLIENBTGATEWAYPOSTTIMEOUT { get; set; }

		public string CLIENTGATEWAYURL { get; set; }

		public string CONFIGSERVICEURL { get; set; }

		public string CONFIGSVCPASSWORD { get; set; }

		public string CONFIGSVCUSERNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public string HELPERSERVICEENDPOINTS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? LOGPURGECRITICALINTERVAL { get; set; }

		public uint? LOGPURGEDEBUGINTERVAL { get; set; }

		public uint? LOGPURGEFREQUENCY { get; set; }

		public uint? LOGPURGEINTERVAL { get; set; }

		public uint? LOGPURGEMAXCYCLES { get; set; }

		public uint? LOGPURGEROWSPERCYCLE { get; set; }

		public string LOGSERVICEENDPOINTS { get; set; }

		public string MAPSERVICEENDPOINTS { get; set; }

		public uint? MAXIMUMLOGLEVEL { get; set; }

		public uint? MAXIMUMMETRICLEVEL { get; set; }

		public string NOTES { get; set; }

		public uint? PERSISTEXPIREDINTEVAL { get; set; }

		public uint? PERSISTLOADINTERVAL { get; set; }

		public string ROUTERSERVICEENDPOINTS { get; set; }

		public string SERVICEBEHAVIORS { get; set; }

		public string SETTINGSPERSISTID { get; set; }

		public string SETUPACCESS { get; set; }

		public string SMTPTRANSPORTID { get; set; }

		public string WORKFLOWSTORECONNECTIONNAME { get; set; }

		public string WORKFLOWSTORECONNECTIONSTRING { get; set; }

		public string WORKFLOWSTOREPLUGIN { get; set; }

		public uint? WORKFLOWUNAVAILABLEMAXTIME { get; set; }

	}

}
