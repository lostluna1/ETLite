using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QUERYTEXT {

		public uint? DBTYPEID { get; set; }

		public uint? QUERYDEFID { get; set; }

		public string QUERY_TEXT { get; set; }

		public uint? QUERYTEXTID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
