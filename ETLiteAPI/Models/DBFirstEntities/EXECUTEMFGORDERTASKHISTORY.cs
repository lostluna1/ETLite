using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXECUTEMFGORDERTASKHISTORY {

		public string EXECUTEMFGORDERTASKHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXECUTEMFGORDERTASKHISTORYNAME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MFGORDERID { get; set; }

		public uint? MFGORDERINSTRUCTIONTYPE { get; set; }

		public string MFGORDERPROCEDUREID { get; set; }

		public string MFGORDERTASKLISTID { get; set; }

		public uint? PASS { get; set; }

		public string TASKCOMMENTS { get; set; }

		public uint? TASKCOMPLETE { get; set; }

		public uint? TASKFAILED { get; set; }

		public string TASKID { get; set; }

		public string TASKINSTRUCTION { get; set; }

		public uint? TASKLISTSEQUENCE { get; set; }

		public uint? TASKSEQUENCE { get; set; }

		public string TASKSTATUSID { get; set; }

		public uint? TASKTYPE { get; set; }

		public string TRAININGREQGROUPID { get; set; }

		public string TXNID { get; set; }

	}

}
