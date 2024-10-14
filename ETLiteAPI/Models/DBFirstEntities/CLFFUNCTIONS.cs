using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFFUNCTIONS {

		public uint? CLFFUNCTIONID { get; set; }

		public uint? CLFID { get; set; }

		public uint? FUNCTIONID { get; set; }

		public bool? ISACTIVE { get; set; }

		public uint? SEQUENCE { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
