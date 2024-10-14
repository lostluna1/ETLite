using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTFAILUREACTIONHISTORYDTL {

		public string EVENTFAILUREACTIONHISTORYDTLID { get; set; }

		public string ACTIONOWNERID { get; set; }

		public string ACTIONTYPEID { get; set; }

		public string CAUSECODEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETIONDATE { get; set; }

		public string EVENTFAILURECAUSEHISTDTLSID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREMODEID { get; set; }

		public string HISTORYID { get; set; }

		public string TXNID { get; set; }

	}

}
