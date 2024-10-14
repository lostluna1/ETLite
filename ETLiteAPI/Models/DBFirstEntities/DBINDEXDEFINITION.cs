using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBINDEXDEFINITION {

		public string DBINDEXDESCRIPTION { get; set; }

		public uint? DBINDEXID { get; set; }

		public string DBINDEXNAME { get; set; }

		public uint? DBTABLEDEFID { get; set; }

		public bool? ISDISABLE { get; set; }

		public bool? ISUNIQUE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
