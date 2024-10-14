using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SQLDATATYPES {

		public uint SQLTYPEVALUE { get; set; }

		public string DATATYPEDESCRIPTION { get; set; }

		public string SQLTYPE { get; set; }

	}

}
