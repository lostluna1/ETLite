using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_PRODUCTPLAN {

		public string ENDTIME { get; set; }

		public string MFGEQP { get; set; }

		public string MFGORDER { get; set; }

		public string SPEC { get; set; }

		public string STARTTIME { get; set; }

	}

}
