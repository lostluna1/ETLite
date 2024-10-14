using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_RESOURCE {

		public string EQPTYPE { get; set; }

		public string LOCATION { get; set; }

		public string MFGLINE { get; set; }

		public string MFGLINESTATUS { get; set; }

		public string PLANT { get; set; }

		public string RESOURCECAPABILITY { get; set; }

		public string RESOURCEDESCRIPTION { get; set; }

		public string RESOURCENAME { get; set; }

		public string RESOURCESTATUS { get; set; }

	}

}
