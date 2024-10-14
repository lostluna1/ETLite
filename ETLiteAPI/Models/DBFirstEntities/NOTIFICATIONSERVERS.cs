using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NOTIFICATIONSERVERS {

		public string HOSTNAME { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public string SERVERID { get; set; }

		public string SERVERTYPE { get; set; }

		public uint? STATUS { get; set; }

	}

}
