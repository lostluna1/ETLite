using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HVCOMPONENTREMOVEHISTORY {

		public string HVCOMPONENTREMOVEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string HVCOMPONENTREMOVEHISTORYNAME { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string SPECID { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
