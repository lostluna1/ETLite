using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSILABELVIEW {

		public uint? CATEGORYID { get; set; }

		public uint? LABELID { get; set; }

		public string LABELVALUE { get; set; }

		public string LANGID { get; set; }

		public string NAME { get; set; }

		public string TERMID { get; set; }

	}

}
