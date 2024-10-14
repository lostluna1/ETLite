using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_CUSTOMERPRODUCTNAME {

		public string BIZ_CUSTOMERPRODUCT { get; set; }

		public string BIZ_CUSTOMERPRODUCTNAME { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

	}

}
