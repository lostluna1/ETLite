using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_POWERON_INSPECTION_NEW {

		public string BIZ_EQUIPSTATUS { get; set; }

		public string BIZ_USAGE { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public DateTime? EXECUTION_TIME { get; set; }

		public string FAMILY_DES { get; set; }

		public string FAMILY_NAME { get; set; }

		public string MFGORDER { get; set; }

		public string MFGORDER_ID { get; set; }

		public string OBJECT_TYPE { get; set; }

		public string POWERONDET_NAME { get; set; }

		public string POWERONINSPECTION_NAME { get; set; }

		public string RESOURCE_NAME { get; set; }

	}

}
