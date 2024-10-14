using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SIGNAPPROVALHISTORY {

		public string SIGNAPPROVALHISTORYID { get; set; }

		public DateTime? APPROVALCYCLE { get; set; }

		public DateTime? APPROVALCYCLEGMT { get; set; }

		public string APPROVALDECISIONID { get; set; }

		public string APPROVALSHEETENTRYID { get; set; }

		public string APPROVALSHEETID { get; set; }

		public string APPROVEDBYID { get; set; }

		public string APPROVERID { get; set; }

		public string APPROVERROLEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETEBY { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public uint? DECISIONTYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public DateTime? LASTCOMPLETEDON { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public DateTime? LASTROUTEDON { get; set; }

		public DateTime? LASTROUTEDONGMT { get; set; }

		public string PROCESSOBJECTID { get; set; }

		public string QUALITYOBJECTID { get; set; }

		public uint? SHEETLEVEL { get; set; }

		public string SPECIALINSTRUCTIONS { get; set; }

		public string TRACKABLEOBJECTID { get; set; }

		public string TXNID { get; set; }

	}

}
