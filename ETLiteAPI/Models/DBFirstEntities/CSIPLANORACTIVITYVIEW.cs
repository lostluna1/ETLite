using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIPLANORACTIVITYVIEW {

		public uint? ALLOWREASSIGNMENT { get; set; }

		public DateTime? ASSIGNEDONGMT { get; set; }

		public string ASSIGNEEID { get; set; }

		public string ASSIGNEEROLEID { get; set; }

		public string ATTACHMENTSID { get; set; }

		public uint? AUTOCOMPLETE { get; set; }

		public uint? AUTOSTART { get; set; }

		public uint? CDOTYPEID { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public uint? COMPLETEWITHINQTY { get; set; }

		public string DOCUMENTSETID { get; set; }

		public DateTime? FIRSTROUTEDONGMT { get; set; }

		public string ID { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISREQUIRED { get; set; }

		public string LASTCOMPLETEDBYID { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public string NAME { get; set; }

		public string NOTES { get; set; }

		public string OWNERID { get; set; }

		public string OWNERROLEID { get; set; }

		public string PROCESSMODELID { get; set; }

		public string REASSIGNMENTCOMMENTS { get; set; }

		public string SORTID { get; set; }

		public string SORTLEVEL { get; set; }

		public uint? STAGE { get; set; }

		public string TYPE { get; set; }

	}

}
