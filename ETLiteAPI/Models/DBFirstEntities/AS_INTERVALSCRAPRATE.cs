using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_INTERVALSCRAPRATE {

		public string BU { get; set; }

		public string INTERVAFROM { get; set; }

		public string INTERVATO { get; set; }

		public string PARTNO { get; set; }

		public string SCRAPRATE { get; set; }

	}

}
