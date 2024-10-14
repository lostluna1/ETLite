using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EQPT_ACCOUNT_REPORT {

		public string FACTORYNAME { get; set; }

		public string FAMILY_DESCRIPTION { get; set; }

		public string RESC_DESCRIPTION { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
