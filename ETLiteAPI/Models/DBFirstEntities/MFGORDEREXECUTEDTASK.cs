using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGORDEREXECUTEDTASK {

		public string MFGORDEREXECUTEDTASKID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? EXECUTIONCOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LASTCOMMENT { get; set; }

		public DateTime? LASTEXECUTIONTIME { get; set; }

		public DateTime? LASTEXECUTIONTIMEGMT { get; set; }

		public string MFGORDEREXECUTEDTASKNAME { get; set; }

		public string MFGORDERID { get; set; }

		public string TASKID { get; set; }

		public uint? TASKSTATE { get; set; }

		public string TASKSTATUSID { get; set; }

	}

}
