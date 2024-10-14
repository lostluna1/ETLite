using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_MFGORDERREASSIGNPLANES_MFGO {

		public string ES_MFGORDERREASSIGNPLANID { get; set; }

		public uint FIELDID { get; set; }

		public uint SEQUENCE { get; set; }

		public string ES_MFGORDERREASSIGNPLANDETAIID { get; set; }

	}

}
