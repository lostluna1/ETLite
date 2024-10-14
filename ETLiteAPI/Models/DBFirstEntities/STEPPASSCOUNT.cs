using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class STEPPASSCOUNT {

		public string STEPPASSCOUNTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? LOOPPASS { get; set; }

		public string STEPID { get; set; }

		public uint? STEPPASS { get; set; }

	}

}
