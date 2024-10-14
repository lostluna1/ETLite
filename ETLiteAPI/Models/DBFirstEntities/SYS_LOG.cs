using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_LOG {

		public DateTime? BEGINDATE { get; set; }

		public string BROWSERTYPE { get; set; }

		public int? ELAPSEDTIME { get; set; }

		public DateTime? ENDDATE { get; set; }

		public string EXCEPTIONINFO { get; set; }

		public int ID { get; set; }

		public string LOGTYPE { get; set; }

		public string REQUESTPARAMETER { get; set; }

		public string RESPONSEPARAMETER { get; set; }

		public int? ROLE_ID { get; set; }

		public string SERVICEIP { get; set; }

		public int? SUCCESS { get; set; }

		public string URL { get; set; }

		public int? USER_ID { get; set; }

		public string USERIP { get; set; }

		public string USERNAME { get; set; }

	}

}
