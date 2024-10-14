using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOOUTBOUNDHEADERKEYVALUE {

		public string CIOOUTBOUNDHEADERKEYVALUEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOOUTBOUNDDEFINITIONID { get; set; }

		public string CIOOUTBOUNDHEADERKEYVALUENAME { get; set; }

		public string HEADERKEY { get; set; }

		public string HEADERVALUE { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
