using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_WORKORDERPROGRESS {

		public string CONTAINER { get; set; }

		public string CONTAINERID { get; set; }

		public string EQP { get; set; }

		public string EQPID { get; set; }

		public uint? HOLD { get; set; }

		public string MFGORDER { get; set; }

		public uint? STATUS { get; set; }

		public string STEP { get; set; }

		public string STEPID { get; set; }

		public string WORKFLOW { get; set; }

		public string WORKFLOWREVISION { get; set; }

	}

}
