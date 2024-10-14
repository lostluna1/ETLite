using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CDOMAPDEFINITION {

		public uint? CDOMAPID { get; set; }

		public string DESCRIPTION { get; set; }

		public string NAME { get; set; }

		public uint? PARENTCDOMAPID { get; set; }

		public uint? SOURCECDOID { get; set; }

		public uint? TARGETCDOID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
