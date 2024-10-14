using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CDOFIELDMAPDEFINITION {

		public bool? ACCUMULATE { get; set; }

		public bool? CARRYFORWARD { get; set; }

		public uint? CDOFIELDMAPID { get; set; }

		public uint? CDOMAPID { get; set; }

		public bool? ISDISABLED { get; set; }

		public uint? SOURCECDOFIELDID { get; set; }

		public uint? TARGETCDOFIELDID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
