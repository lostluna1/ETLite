using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXCLUDELETTERSMAP {

		public string EXCLUDELETTERSMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXCLUDELETTERSMAPNAME { get; set; }

		public uint? EXCLUDEVALUE { get; set; }

		public string PARENTID { get; set; }

	}

}
