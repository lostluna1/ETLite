using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERCOMPLETEDTASK {

		public string CONTAINERCOMPLETEDTASKID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? COMPLETIONTIMESTAMP { get; set; }

		public DateTime? COMPLETIONTIMESTAMPGMT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LASTREVTXNID { get; set; }

		public uint? NBRTIMESPROCESSED { get; set; }

		public uint? PASS { get; set; }

		public string TASKID { get; set; }

		public uint? TASKISMARKEDCOMPLETED { get; set; }

	}

}
