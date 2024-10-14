using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RISKASSESSMENT {

		public string RISKASSESSMENTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public uint? DETECTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? OCCURRENCE { get; set; }

		public string PARENTID { get; set; }

		public uint? RISKASSESSMENTNOTREQUIRED { get; set; }

		public uint? RPN { get; set; }

		public uint? SEVERITY { get; set; }

	}

}
