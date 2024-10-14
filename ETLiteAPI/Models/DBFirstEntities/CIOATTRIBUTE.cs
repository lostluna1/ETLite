using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOATTRIBUTE {

		public string CIOATTRIBUTEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOATTRIBUTENAME { get; set; }

		public string CIOFUNCTIONID { get; set; }

		public uint? DONOTPROMOTE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FUNCTIONARGS { get; set; }

		public uint? INCLUDEINEVENT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

	}

}
