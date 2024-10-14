using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELETE_RP_DASHBOARD_LEVEL1 {

		public string ACHIEVEMENT { get; set; }

		public string ADDQTY { get; set; }

		public string CREATION_DATE { get; set; }

		public string EFFCIENCY { get; set; }

		public string FACTORYNAME { get; set; }

		public string FQCNGQTY { get; set; }

		public string FQCPASSQTY { get; set; }

		public string PLANQTY { get; set; }

		public string SHIFTCOMPLATEQTY { get; set; }

		public string YIELD { get; set; }

	}

}
