using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_JOBIMAGES {

		public string ES_JOBIMAGESID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ES_IMAGEID { get; set; }

		public string ES_JOBIMAGESNAME { get; set; }

		public string ES_NPIJOBID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
