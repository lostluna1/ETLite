using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TIMER {

		public string TIMERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? ENDTIMEGMT { get; set; }

		public string ENDTIMERSPECID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISSTOPED { get; set; }

		public DateTime? MAXENDTIMEGMT { get; set; }

		public DateTime? MAXENDWARNINGTIMEGMT { get; set; }

		public string MAXTIMECOLOR { get; set; }

		public string MAXWARNINGTIMECOLOR { get; set; }

		public DateTime? MINENDTIMEGMT { get; set; }

		public DateTime? MINENDWARNINGTIMEGMT { get; set; }

		public string MINTIMECOLOR { get; set; }

		public string MINWARNINGTIMECOLOR { get; set; }

		public string PARENTID { get; set; }

		public string PROCESSTIMERID { get; set; }

		public string PROCESSTIMERNAME { get; set; }

		public string PROCESSTIMERREVISION { get; set; }

		public string PROCESSTIMERREVOFRCDID { get; set; }

		public string SPECSTARTTIMERID { get; set; }

		public DateTime? STARTTIMEGMT { get; set; }

		public string TASKSTARTTIMERID { get; set; }

		public string TIMERCOMPLETIONSTATUSNAME { get; set; }

	}

}
