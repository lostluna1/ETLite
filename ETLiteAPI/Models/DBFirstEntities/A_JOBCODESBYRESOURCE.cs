using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBCODESBYRESOURCE {

		public string JOBCODESBYRESOURCEID { get; set; }

		public string CAUSECODEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? NUMBEROFOCCURRENCES { get; set; }

		public string REPAIRCODEID { get; set; }

		public string RESOURCEID { get; set; }

		public string SYMPTOMCODEID { get; set; }

	}

}
