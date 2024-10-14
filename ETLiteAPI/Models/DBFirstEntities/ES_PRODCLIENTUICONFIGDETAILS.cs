using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_PRODCLIENTUICONFIGDETAILS {

		public string ES_PRODCLIENTUICONFIGDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_PRODCLIENTUICONFIGDETAINAME { get; set; }

		public string ES_PRODCLIENTUICONFIGID { get; set; }

		public string ES_PRODCLIENTUICONFIGLABELNAME { get; set; }

		public string ES_PRODCLIENTUICONFIGLABELTEXT { get; set; }

		public string ES_PRODCLIENTUICONFIGNAME { get; set; }

		public uint? ES_PRODCLIENTUICONFIGSEQUENCE { get; set; }

		public uint? ES_PRODCLIENTUICONFIGTYPE { get; set; }

		public uint? ES_PRODCLIENTUICONFIGVISIBLE { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
