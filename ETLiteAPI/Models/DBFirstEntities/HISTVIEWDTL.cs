using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HISTVIEWDTL {

		public string HISTVIEWDTLID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYVIEWID { get; set; }

		public string HISTVIEWDTLNAME { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
