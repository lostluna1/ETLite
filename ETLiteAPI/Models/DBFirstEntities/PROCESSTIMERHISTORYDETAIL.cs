using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSTIMERHISTORYDETAIL {

		public string PROCESSTIMERHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DEFINEDMAXTIME { get; set; }

		public string DEFINEDMINTIME { get; set; }

		public DateTime? ENDTIMEGMT { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string PROCESSTIMERHISTORYDETAILNAME { get; set; }

		public string PROCESSTIMERNAME { get; set; }

		public DateTime? STARTTIMEGMT { get; set; }

		public string TIMERCOMPLETIONSTATUSNAME { get; set; }

		public string TXNID { get; set; }

	}

}
