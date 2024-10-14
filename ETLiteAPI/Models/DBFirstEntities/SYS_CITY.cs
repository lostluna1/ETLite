using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_CITY {

		public string CITYCODE { get; set; }

		public int CITYID { get; set; }

		public string CITYNAME { get; set; }

		public string PROVINCECODE { get; set; }

	}

}
