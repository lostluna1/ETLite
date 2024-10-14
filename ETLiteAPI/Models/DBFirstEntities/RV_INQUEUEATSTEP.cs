using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_INQUEUEATSTEP {

		public decimal? CONTAINERCOUNT { get; set; }

		public string MFGORDERID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
