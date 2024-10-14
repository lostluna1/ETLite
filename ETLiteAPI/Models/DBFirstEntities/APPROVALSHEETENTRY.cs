using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class APPROVALSHEETENTRY {

		public string APPROVALSHEETENTRYID { get; set; }

		public string APPROVALDECISIONID { get; set; }

		public string APPROVEDBYID { get; set; }

		public string APPROVERID { get; set; }

		public string APPROVERROLEID { get; set; }

		public string ASSIGNEDAPPROVERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETEBY { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public uint? COMPLETEWITHINQTY { get; set; }

		public decimal? COMPLETEWITHINUOM { get; set; }

		public uint? DECISIONTYPE { get; set; }

		public string DELEGATIONTASKID { get; set; }

		public uint? EDITOPTION { get; set; }

		public uint? ENTRYREQUIRED { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? FIRSTROUTEDON { get; set; }

		public DateTime? FIRSTROUTEDONGMT { get; set; }

		public uint? ISFROZEN { get; set; }

		public DateTime? LASTCOMPLETEDON { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public string LASTDECISIONID { get; set; }

		public DateTime? LASTROUTEDON { get; set; }

		public DateTime? LASTROUTEDONGMT { get; set; }

		public string PARENTID { get; set; }

		public string PLMAPPROVALCODE { get; set; }

		public string PLMAPPROVALURL { get; set; }

		public uint? SHEETLEVEL { get; set; }

		public string SPECIALINSTRUCTIONS { get; set; }

		public uint? STATUS { get; set; }

		public uint? SUBSTITUTEOPTION { get; set; }

	}

}
