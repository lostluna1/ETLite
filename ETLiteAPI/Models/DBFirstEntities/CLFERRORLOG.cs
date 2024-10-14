using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFERRORLOG {

		public string CLFPKG { get; set; }

		public DateTime? LOGDATE { get; set; }

		public string LOGMESSAGE { get; set; }

	}

}
