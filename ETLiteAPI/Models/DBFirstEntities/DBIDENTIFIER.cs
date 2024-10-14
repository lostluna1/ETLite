using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBIDENTIFIER {

		public string SITENAME { get; set; }

		public DateTime? ASSIGNMENTTIMESTAMP { get; set; }

		public string DB_IDENTIFIER { get; set; }

	}

}
