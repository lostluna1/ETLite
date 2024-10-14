using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSTEMINFO {

		public string INFONAME { get; set; }

		public string INFOSOURCE { get; set; }

		public string INFOVALUE { get; set; }

	}

}
