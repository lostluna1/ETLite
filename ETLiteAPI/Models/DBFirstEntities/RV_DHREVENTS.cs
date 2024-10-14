using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHREVENTS {

		public string COMMENTS { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string EVENTNAME { get; set; }

		public string EVENTSTATUS { get; set; }

		public string FAILUREMODENAME { get; set; }

		public string FS_FAILURESEVERITYNAME { get; set; }

		public string LOT { get; set; }

		public string NCRCAUSECODENAME { get; set; }

		public string NCRFAILURETYPENAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public string QUALITYRESOLUTIONCODENAME { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

	}

}
