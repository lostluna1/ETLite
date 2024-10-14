using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSMODELONCOMPLETERULES {

		public uint FIELDID { get; set; }

		public string PROCESSMODELID { get; set; }

		public uint SEQUENCE { get; set; }

		public string ONCOMPLETERULESID { get; set; }

	}

}
