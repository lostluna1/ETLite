using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBTABLEDEFINITION {

		public uint? CHANGECOUNT { get; set; }

		public uint? DBCATEGORYID { get; set; }

		public string DBTABLEDESCRIPTION { get; set; }

		public uint? DBTABLEID { get; set; }

		public string DBTABLENAME { get; set; }

		public uint? DBTABLETYPE { get; set; }

		public bool? PROPAGATE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
