using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NCRCOMMENTS {

		public string NCRCOMMENTSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string LASTREVTXNID { get; set; }

		public string NONCONFORMANCEREPORTID { get; set; }

	}

}
