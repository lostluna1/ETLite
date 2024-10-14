using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFFUNPARMVAL {

		public uint? CLFFUNCTIONPARMVALUEID { get; set; }

		public string PARMVALUE { get; set; }

		public string PARMVALUESTRING { get; set; }

		public uint? SEQUENCENUMBER { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
