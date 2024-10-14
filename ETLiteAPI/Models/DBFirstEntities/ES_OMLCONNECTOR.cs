using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_OMLCONNECTOR {

		public string ES_OMLCONNECTORID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ES_ISACTIVE { get; set; }

		public string ES_LINEID { get; set; }

		public uint? ES_LOGCIOERRORFILES { get; set; }

		public string Es_OMLCONNECTOR { get; set; }

		public string ES_OMLCONNECTORLISTID { get; set; }

		public string ES_OMLCONNECTORNAME { get; set; }

		public string ES_OMLSERVICEID { get; set; }

		public uint? ES_USEGATEWAY { get; set; }

		public string ES_WEBAPIADAPTERID { get; set; }

		public string ES_WEBAPIADAPTERNAME { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
