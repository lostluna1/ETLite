using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOMACHINEENDPOINTS {

		public string ENDPOINTNAME { get; set; }

		public uint? ENDPOINTTYPE { get; set; }

		public DateTime? LASTUPDATEGMT { get; set; }

		public string LOCALBINDING { get; set; }

		public string LOCALBINDINGCONFIG { get; set; }

		public string LOCALURI { get; set; }

		public string MACHINENAME { get; set; }

		public string REMOTEBINDING { get; set; }

		public string REMOTEBINDINGCONFIG { get; set; }

		public string REMOTEURI { get; set; }

	}

}
