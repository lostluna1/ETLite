using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_WORKFLOW {

		public string DESCRIPTION { get; set; }

		public string EQPGROUP { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPEC { get; set; }

		public string SPEC_REV { get; set; }

		public string STEPTIME { get; set; }

		public string WORKFLOW { get; set; }

		public string WORKFLOW_REV { get; set; }

		public string YIELD { get; set; }

	}

}
