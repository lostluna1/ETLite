using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIVIEW_EVENTTREND {

		public DateTime? CLOSEDATE { get; set; }

		public DateTime? EVENTDATE { get; set; }

		public string EVENTID { get; set; }

		public string EVENTNAME { get; set; }

		public string FAILUREMODENAME { get; set; }

		public string FAILURESEVERITYNAME { get; set; }

		public string MYSTATUS { get; set; }

		public string NCRCAUSECODENAME { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

	}

}
