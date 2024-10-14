using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class IMPORTHEADERDATA {

		public uint IMPORTHEADERID { get; set; }

		public uint? IMPORTACTIONIFMODIFIED { get; set; }

		public uint? IMPORTIFEXISTS { get; set; }

		public uint? IMPORTSETHEADERID { get; set; }

	}

}
