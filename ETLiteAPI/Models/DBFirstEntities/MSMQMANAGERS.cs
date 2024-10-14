using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MSMQMANAGERS {

		public string HOSTNAME { get; set; }

		public uint PORTNUMBER { get; set; }

		public DateTime? LASTUPDATETIME { get; set; }

	}

}
