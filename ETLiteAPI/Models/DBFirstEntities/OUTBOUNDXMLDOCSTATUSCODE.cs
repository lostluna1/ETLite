using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class OUTBOUNDXMLDOCSTATUSCODE {

		public uint STATUSCODEID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? OKTOPROCESS { get; set; }

		public uint? OKTOREMOVE { get; set; }

		public string STATUSCODENAME { get; set; }

	}

}
