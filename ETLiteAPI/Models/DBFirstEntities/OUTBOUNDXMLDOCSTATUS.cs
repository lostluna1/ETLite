using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class OUTBOUNDXMLDOCSTATUS {

		public uint DOCID { get; set; }

		public string TXNID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public uint? RETRYCOUNT { get; set; }

		public uint? STATUSCODEID { get; set; }

		public string TRANSPORTID { get; set; }

	}

}
