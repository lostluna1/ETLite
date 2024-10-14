using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOCDOSERVICEUSAGE {

		public string CDONAME { get; set; }

		public uint? ENDPOINTTYPE { get; set; }

	}

}
