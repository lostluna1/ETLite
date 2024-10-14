using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_FG_SUB {

		public DateTime? CREATION_DATE { get; set; }

		public string FG_RFID { get; set; }

		public string MFGORDER_NAME { get; set; }

		public string SUB_MFGORDER_NAME { get; set; }

		public string SUB_RFID { get; set; }

	}

}
