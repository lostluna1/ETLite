using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOHTTPHEADER {

		public string CIOHTTPHEADERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CIOACTIVEFORDELETE { get; set; }

		public uint? CIOACTIVEFORGET { get; set; }

		public uint? CIOACTIVEFORPOST { get; set; }

		public uint? CIOACTIVEFORPUT { get; set; }

		public string CIOHEADERVALUE { get; set; }

		public string CIOHTTPHEADERNAME { get; set; }

		public string CIOWEBAPICLIENTADAPTERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
