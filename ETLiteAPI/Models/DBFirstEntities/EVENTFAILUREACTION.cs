using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTFAILUREACTION {

		public string EVENTFAILUREACTIONID { get; set; }

		public string ACTIONOWNERID { get; set; }

		public string ACTIONTYPEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETIONDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string PARENTID { get; set; }

	}

}
