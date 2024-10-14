using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LABELTXNMAP {

		public string LABELTXNMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LABELCOUNT { get; set; }

		public string PARENTID { get; set; }

		public string PRINTERLABELDEFINITIONBASEID { get; set; }

		public string PRINTERLABELDEFINITIONID { get; set; }

		public uint? TXNTYPE { get; set; }

	}

}
