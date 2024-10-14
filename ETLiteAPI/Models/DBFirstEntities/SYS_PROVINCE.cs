using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_PROVINCE {

		public int PROVINCEID { get; set; }

		public string PROVINCECODE { get; set; }

		public string PROVINCENAME { get; set; }

		public string REGIONCODE { get; set; }

	}

}
