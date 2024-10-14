using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_JOB_DOCUMENTS {

		public string ES_JOBDOCUMENTSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_DOCUMENTID { get; set; }

		public string ES_JOBDOCUMENTSNAME { get; set; }

		public string ES_NPIJOBID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
