using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSOBJECT_PARENT {

		public string ID { get; set; }

		public string OWNER { get; set; }

		public decimal? PARENTTYPE { get; set; }

		public uint? STAGE { get; set; }

	}

}
