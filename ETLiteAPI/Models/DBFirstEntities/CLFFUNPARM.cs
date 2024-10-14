using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CLFFUNPARM {

		public uint? CLFEVENTMAPID { get; set; }

		public uint? CLFFUNCTIONID { get; set; }

		public uint? CLFFUNCTIONPARMVALUEID { get; set; }

		public bool? DYNAMICPARM { get; set; }

		public uint? FUNCTIONPARMID { get; set; }

		public string VALUEEXPRESSION { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
