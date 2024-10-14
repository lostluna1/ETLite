using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOROUTERSTATUS {

		public uint? BROKERCOUNT { get; set; }

		public uint? CHANNELSOURCECOUNT { get; set; }

		public DateTime? LASTUPDATEGMT { get; set; }

		public string MACHINENAME { get; set; }

		public string TABLENAME { get; set; }

	}

}
