using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIACTIVITYVIEW {

		public string ACTIVITYID { get; set; }

		public string ACTIVITYNAME { get; set; }

		public uint? ALLOWREASSIGNMENT { get; set; }

		public string ASSIGNEEID { get; set; }

		public string ASSIGNEEROLEID { get; set; }

		public string ATTACHMENTSID { get; set; }

		public uint? AUTOCOMPLETE { get; set; }

		public uint? AUTOSTART { get; set; }

		public uint? CDOTYPEID { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETEBY { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public uint? COMPLETEWITHINQTY { get; set; }

		public string DATAPOINTCOLLECTIONID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DESIGNATED { get; set; }

		public string DOCUMENTSETID { get; set; }

		public DateTime? FIRSTROUTEDONGMT { get; set; }

		public uint? ISREQUIRED { get; set; }

		public string LASTCOMPLETEDBYID { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public DateTime? LASTDESIGNATEDON { get; set; }

		public DateTime? LASTDESIGNATEDONGMT { get; set; }

		public uint? LASTSTAGE { get; set; }

		public string PLANID { get; set; }

		public decimal? PLANLASTSTAGE { get; set; }

		public decimal? PLANSTAGE { get; set; }

		public string PROCESSMODELID { get; set; }

		public string REASSIGNMENTCOMMENTS { get; set; }

		public uint? STAGE { get; set; }

	}

}
