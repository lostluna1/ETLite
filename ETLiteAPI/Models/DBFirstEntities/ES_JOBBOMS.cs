using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_JOBBOMS {

		public string ES_JOBBOMSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_BOMID { get; set; }

		public string ES_JOBBOMSNAME { get; set; }

		public string ES_NPIJOBID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
