using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HISTORYCROSSREF {

		public string HISTORYCROSSREFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CROSSREFTYPE { get; set; }

		public string ENDTXNID { get; set; }

		public string HISTORYID { get; set; }

		public string STARTTXNID { get; set; }

		public string TRACKINGID { get; set; }

	}

}
