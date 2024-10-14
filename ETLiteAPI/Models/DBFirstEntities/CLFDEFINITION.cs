using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFDEFINITION {

		public string CLFDESCRIPTION { get; set; }

		public uint? CLFID { get; set; }

		public string CLFNAME { get; set; }

		public uint? CLFTYPE { get; set; }

		public uint? FEATUREID { get; set; }

		public uint? FUNCTIONID { get; set; }

		public uint? SOURCECLFID { get; set; }

		public uint? VISIBILITY { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
