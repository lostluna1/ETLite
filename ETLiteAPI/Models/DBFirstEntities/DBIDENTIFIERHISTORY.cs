using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBIDENTIFIERHISTORY {

		public DateTime ASSIGNMENTTIMESTAMP { get; set; }

		public string DBIDENTIFIER { get; set; }

		public string SITENAME { get; set; }

		public DateTime? REMOVALTIMESTAMP { get; set; }

	}

}
