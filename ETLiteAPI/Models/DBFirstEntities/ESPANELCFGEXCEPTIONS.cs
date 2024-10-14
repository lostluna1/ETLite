using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESPANELCFGEXCEPTIONS {

		[JsonProperty, Column(Name = "ES_PANELCFGEXCEPTIONSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPANELCFGEXCEPTIONSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty, Column(Name = "ES_OPERATIONID", DbType = "CHAR(16 BYTE)")]
		public string ESOPERATIONID { get; set; }

		[JsonProperty, Column(Name = "ES_PANELCFGEXCEPTIONSNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESPANELCFGEXCEPTIONSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PANELCONFIGURATION")]
		public uint? ESPANELCONFIGURATION { get; set; }

		[JsonProperty, Column(Name = "ES_RESOURCEID", DbType = "CHAR(16 BYTE)")]
		public string ESRESOURCEID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
