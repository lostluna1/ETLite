using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRACKABLEOBJECTCURRENTSTATUS {

		public string TRACKABLEOBJECTCURRENTSTATUSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? LASTMOVEDATE { get; set; }

		public DateTime? LASTMOVEDATEGMT { get; set; }

		public string SPECID { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
