using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FAILUREPLANDATA {

		public string FAILUREPLANDATAID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILURECAUSEDATAID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PLANID { get; set; }

		public uint? PLANTYPE { get; set; }

	}

}
