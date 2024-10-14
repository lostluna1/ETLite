using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ACTIVEUSERSESSION {

		public string ACTIVEUSERSESSIONID { get; set; }

		public string APPLICATIONNAME { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public DateTime? LASTACTIVITYDATEGMT { get; set; }

		public string USERDOMAIN { get; set; }

		public string USERNAME { get; set; }

	}

}
