using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LICENSEINFO {

		public string ID { get; set; }

		public DateTime? LASTHEARTBEATDATE { get; set; }

		public DateTime? LASTHEARTBEATDATEGMT { get; set; }

		public string LICENSEINFOBLOB { get; set; }

		public string OWNER { get; set; }

	}

}
