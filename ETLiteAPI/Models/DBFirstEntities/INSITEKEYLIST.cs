using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class INSITEKEYLIST {

		public uint RECID { get; set; }

		public string FORGNCOLNAME { get; set; }

		public string FORGNTBLNAME { get; set; }

		public string KEYLCOLLOCALNAME { get; set; }

		public string TABLENAME { get; set; }

	}

}
