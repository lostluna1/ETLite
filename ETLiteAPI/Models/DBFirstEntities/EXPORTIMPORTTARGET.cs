using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPORTIMPORTTARGET {

		public uint EXPORTIMPORTTARGETID { get; set; }

		public uint? EXPORTIMPORTHEADERID { get; set; }

		public string TARGETSYSTEMID { get; set; }

		public uint? TRACKABLEOBJECTCDOTYPEID { get; set; }

		public string TRACKABLEOBJECTID { get; set; }

	}

}
