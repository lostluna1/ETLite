using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_WIP_WAITING {

		public string CURRENTSTEP { get; set; }

		public string IDENTIFIER { get; set; }

		public string ISFAILED { get; set; }

		public DateTime? LASTMOVEDATE { get; set; }

		public string MFGORDERNAME { get; set; }

		public string NEXTSTEP { get; set; }

		public string PREVSTEP { get; set; }

	}

}
