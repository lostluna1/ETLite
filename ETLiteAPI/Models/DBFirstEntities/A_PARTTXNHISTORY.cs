using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PARTTXNHISTORY {

		public string PARTTXNHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMREQUESTSTATUS { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISDONE { get; set; }

		public string JOBID { get; set; }

		public uint? PARTDECOMMISSIONED { get; set; }

		public string REQUESTORDERID { get; set; }

		public string REQUESTORDERNAME { get; set; }

		public string REQUESTSTATUS { get; set; }

		public uint? REQUESTTYPE { get; set; }

		public uint? REQUIREACKNOWLEDGEEMAIL { get; set; }

		public uint? SCRAPQTY { get; set; }

		public string TXNID { get; set; }

	}

}
