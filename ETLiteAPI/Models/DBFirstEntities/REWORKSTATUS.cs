using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class REWORKSTATUS {

		public string REWORKSTATUSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public string ENDREWORKSTEPID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string LASTREVTXNID { get; set; }

		public string REENTRYSTEPID { get; set; }

		public string REWORKREASONID { get; set; }

	}

}
