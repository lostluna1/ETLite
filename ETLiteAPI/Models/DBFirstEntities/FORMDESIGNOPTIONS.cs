using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class FORMDESIGNOPTIONS {

		public string FORMID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DARAGGEOPTIONS { get; set; }

		public string FORMCONFIG { get; set; }

		public string FORMFIELDS { get; set; }

		public string FORMOPTIONS { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string TABLECONFIG { get; set; }

		public string TITLE { get; set; }

	}

}
