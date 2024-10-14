using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBCATEGORIES {

		public uint DBCATEGORYID { get; set; }

		public uint? DATASOURCENAMEID { get; set; }

		public string DBCATEGORYDESCRIPTION { get; set; }

		public bool? EXPOSEDTOSTORAGE { get; set; }

		public bool? EXPOSEDTOTABLE { get; set; }

		public bool? PROPAGATE { get; set; }

	}

}
