using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPLETEMAINTHISTORYDETAILS {

		public string COMPLETEMAINTHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string COMPLETEMAINTENANCEHISTORYID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string JOBID { get; set; }

		public DateTime? LASTDATEDUE { get; set; }

		public DateTime? LASTDATEDUEGMT { get; set; }

		public DateTime? LASTDATELIMIT { get; set; }

		public DateTime? LASTDATELIMITGMT { get; set; }

		public DateTime? LASTDATEWARNING { get; set; }

		public DateTime? LASTDATEWARNINGGMT { get; set; }

		public decimal? LASTTHRUPUTQTY2DUE { get; set; }

		public decimal? LASTTHRUPUTQTY2LIMIT { get; set; }

		public decimal? LASTTHRUPUTQTY2WARNING { get; set; }

		public decimal? LASTTHRUPUTQTYDUE { get; set; }

		public decimal? LASTTHRUPUTQTYLIMIT { get; set; }

		public decimal? LASTTHRUPUTQTYWARNING { get; set; }

		public uint? MAINTENANCECOMPLETED { get; set; }

		public string MAINTENANCEREQID { get; set; }

		public DateTime? SCHEDULEDATE { get; set; }

		public DateTime? SCHEDULEDATEGMT { get; set; }

		public DateTime? SCHEDULEDATELIMIT { get; set; }

		public DateTime? SCHEDULEDATELIMITGMT { get; set; }

		public DateTime? SCHEDULEDATEWARNING { get; set; }

		public DateTime? SCHEDULEDATEWARNINGGMT { get; set; }

		public decimal? THRUPUTQTY { get; set; }

		public decimal? THRUPUTQTY2 { get; set; }

		public string TXNID { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

	}

}
