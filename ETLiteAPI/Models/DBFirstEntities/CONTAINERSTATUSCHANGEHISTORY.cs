using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERSTATUSCHANGEHISTORY {

		public string CONTAINERSTATUSCHANGEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGESTATUSREASONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public uint? INCLUDECHILDREN { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string REMOTECOMPLETIONMSG { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
