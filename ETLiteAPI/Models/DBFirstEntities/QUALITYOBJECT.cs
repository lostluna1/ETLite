using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QUALITYOBJECT {

		public uint? CATEGORY { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string ID { get; set; }

		public string ORGANIZATION { get; set; }

		public string OWNER { get; set; }

		public string PRIORITYLEVEL { get; set; }

		public string PROCESSMODEL { get; set; }

		public uint? QUALITYOBJECTTYPE { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string REPORTER { get; set; }

		public string ROLE { get; set; }

		public uint? STATUS { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public uint? TRIAGECOMPLETE { get; set; }

		public decimal? TYPE { get; set; }

	}

}
