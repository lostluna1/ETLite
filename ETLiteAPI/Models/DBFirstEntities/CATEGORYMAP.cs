using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CATEGORYMAP {

		public string CATEGORYMAPID { get; set; }

		public uint? CATEGORY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OWNERID { get; set; }

		public string PARENTID { get; set; }

		public string ROLEID { get; set; }

		public string TRIAGESPECID { get; set; }

	}

}
