using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SCHEDULEDBIZRULEEXECHISTORY {

		public uint SCHEDULEDBIZRULEEXECHISTORYID { get; set; }

		public string COMPLETIONMSG { get; set; }

		public string EXECUTIONCONTEXT { get; set; }

		public string EXECUTIONCONTEXTDISPLAYNAME { get; set; }

		public uint? EXECUTIONCONTEXTTYPE { get; set; }

		public string EXECUTIONCONTEXTTYPENAME { get; set; }

		public uint? EXECUTIONSTATUS { get; set; }

		public DateTime? EXECUTIONTIME { get; set; }

		public DateTime? EXECUTIONTIMEGMT { get; set; }

		public uint? ISSYSTEMDEFINED { get; set; }

		public DateTime? NEXTEXECUTIONTIME { get; set; }

		public DateTime? NEXTEXECUTIONTIMEGMT { get; set; }

		public string ONEXECUTE { get; set; }

		public string SCHEDULEDBIZRULE { get; set; }

		public string SCHEDULEDBIZRULENAME { get; set; }

	}

}
