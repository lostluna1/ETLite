using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_VIEW_WORKFLOWDEFAULTPATHS {

		public string FROMSTEPID { get; set; }

		public uint? ISLASTSTEP { get; set; }

		public string PATHNAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPECBASEID { get; set; }

		public string SPECID { get; set; }

		public string TOSTEPID { get; set; }

		public string WORKFLOWID { get; set; }

	}

}
