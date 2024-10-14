using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSINGGATE {

		public string PROCESSINGGATEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public string ENTRYSTEPID { get; set; }

		public uint? ENTRYTYPE { get; set; }

		public string EXITSTEPID { get; set; }

		public uint? EXITTYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? GATETYPE { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PROCESSINGGATENAME { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
