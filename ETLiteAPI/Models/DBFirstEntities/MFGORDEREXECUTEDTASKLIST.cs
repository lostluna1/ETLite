using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MFGORDEREXECUTEDTASKLIST {

		public string MFGORDEREXECUTEDTASKLISTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDEREXECUTEDTASKLISTNAME { get; set; }

		public string MFGORDERID { get; set; }

		public string TASKLISTID { get; set; }

		public uint? TASKLISTSTATE { get; set; }

	}

}
