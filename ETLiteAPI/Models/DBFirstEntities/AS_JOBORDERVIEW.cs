using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_JOBORDERVIEW {

		public string BIZ_EQUIPREPAIREXPENSETYPENAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string JOBORDERNAME { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
