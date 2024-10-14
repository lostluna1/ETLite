using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ENDTIMERTXNMAP {

		public string ENDTIMERTXNMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ENDTIMERTXNMAPNAME { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARENTID { get; set; }

		public string PROCESSTIMERID { get; set; }

		public string TXNNAME { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
