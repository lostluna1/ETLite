using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIQUALITYOBJECTVIEW {

		public string DISCOVERYAREA { get; set; }

		public string INSTANCEID { get; set; }

		public string OBJECTNAME { get; set; }

		public string OBJECTTYPE { get; set; }

		public string ORGANIZATIONID { get; set; }

		public string ORGANIZATIONNAME { get; set; }

		public string OWNERNAME { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string ROLENAME { get; set; }

	}

}
