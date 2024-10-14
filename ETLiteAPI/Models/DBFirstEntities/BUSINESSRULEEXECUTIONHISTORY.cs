using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BUSINESSRULEEXECUTIONHISTORY {

		public string BUSINESSRULEEXECUTIONHISTORYID { get; set; }

		public string BUSINESSRULECONDITION { get; set; }

		public string BUSINESSRULENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTEXTDISPLAYNAME { get; set; }

		public string CONTEXTID { get; set; }

		public string CONTEXTTYPENAME { get; set; }

		public DateTime? EXECUTIONTIME { get; set; }

		public DateTime? EXECUTIONTIMEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string TXNID { get; set; }

	}

}
