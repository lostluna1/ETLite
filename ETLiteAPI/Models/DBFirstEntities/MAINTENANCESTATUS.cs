using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MAINTENANCESTATUS {

		public string MAINTENANCESTATUSID { get; set; }

		public string ASSIGNEDMAINTREQID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? DUEEMAILDATE { get; set; }

		public DateTime? DUEEMAILDATEGMT { get; set; }

		public uint? DUEEMAILSENT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? FIRSTMAINTDATEDUE { get; set; }

		public DateTime? FIRSTMAINTDATEDUEGMT { get; set; }

		public string JOBID { get; set; }

		public DateTime? LASTDATEDUE { get; set; }

		public DateTime? LASTDATEDUEGMT { get; set; }

		public string LASTREVTXNID { get; set; }

		public decimal? LASTTHRUPUTQTY { get; set; }

		public decimal? LASTTHRUPUTQTY2 { get; set; }

		public DateTime? MAINTCOMPLETIONDATE { get; set; }

		public DateTime? MAINTCOMPLETIONDATEGMT { get; set; }

		public DateTime? NEXTDATEDUE { get; set; }

		public DateTime? NEXTDATEDUEGMT { get; set; }

		public DateTime? PASTDUEEMAILDATE { get; set; }

		public DateTime? PASTDUEEMAILDATEGMT { get; set; }

		public uint? PASTDUEEMAILSENT { get; set; }

		public DateTime? PENDINGEMAILDATE { get; set; }

		public DateTime? PENDINGEMAILDATEGMT { get; set; }

		public uint? PENDINGEMAILSENT { get; set; }

		public string REASONID { get; set; }

		public string RESOURCEID { get; set; }

		public string STATUSID { get; set; }

		public decimal? THRUPUTQTY2ADJUSTMENT { get; set; }

		public decimal? THRUPUTQTYADJUSTMENT { get; set; }

	}

}
