using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPONENTREPLACEHISTORY {

		public string COMPONENTREPLACEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPONENTREPLACEHISTORYNAME { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string TXNID { get; set; }

	}

}
