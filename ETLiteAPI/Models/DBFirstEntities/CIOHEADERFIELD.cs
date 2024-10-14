using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOHEADERFIELD {

		public string CIOHEADERFIELDID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CIOHEADERSECTIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? HEADERINDEX { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? LENGTH { get; set; }

		public uint? LINENUMBER { get; set; }

		public string NAME { get; set; }

	}

}
