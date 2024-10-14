using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CPACTIVATION {

		public string CPACTIVATIONID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string IMPORTNAME { get; set; }

		public uint? IMPORTPOLLCOUNT { get; set; }

		public DateTime? IMPORTREQUESTDATE { get; set; }

		public string IMPORTSETNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? STATUS { get; set; }

	}

}
