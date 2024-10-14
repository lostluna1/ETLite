using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class IMPORTCONTENTS {

		public uint IMPORTCONTENTSID { get; set; }

		public string IMPORTDATA { get; set; }

		public uint? IMPORTSEQUENCE { get; set; }

		public uint? IMPORTSETHEADERID { get; set; }

		public uint? OBJECTALREADYEXISTS { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public uint? OBJECTISMODIFIED { get; set; }

		public uint? OBJECTISROR { get; set; }

		public string OBJECTNAME { get; set; }

		public string OBJECTREVISION { get; set; }

		public uint? OBJECTTYPEID { get; set; }

		public string OBJECTTYPENAME { get; set; }

	}

}
