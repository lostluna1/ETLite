using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_MFGORDERREASSIGNPLANDETAILS {

		public string ES_MFGORDERREASSIGNPLANDETAIID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_CADDESIGNID { get; set; }

		public string ES_FROMMFGORDERID { get; set; }

		public string ES_MFGORDERREASSIGNPLANDETNAME { get; set; }

		public string ES_MFGORDERREASSIGNPLANID { get; set; }

		public string ES_TOMFGORDERID { get; set; }

		public string ES_WORKFLOWID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
