using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PANELCFGEXCEPTIONS {

		public string ES_PANELCFGEXCEPTIONSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_NPIJOBID { get; set; }

		public string ES_OPERATIONID { get; set; }

		public string ES_PANELCFGEXCEPTIONSNAME { get; set; }

		public uint? ES_PANELCONFIGURATION { get; set; }

		public string ES_RESOURCEID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
