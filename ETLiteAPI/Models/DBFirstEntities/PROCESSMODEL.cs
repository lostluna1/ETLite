using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PROCESSMODEL {

		public string PROCESSMODELID { get; set; }

		public uint? ALLOWREASSIGNMENT { get; set; }

		public string ASSIGNEEID { get; set; }

		public uint? ASSIGNEEOPTION { get; set; }

		public string ASSIGNEEROLEID { get; set; }

		public string ATTACHMENTSID { get; set; }

		public uint? AUTOCOMPLETE { get; set; }

		public uint? AUTOCOMPLETEFAILURE { get; set; }

		public uint? AUTOSTART { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CHECKLISTID { get; set; }

		public string COMPLETIONCOMMENTS { get; set; }

		public string DATAPOINTCOLLECTIONID { get; set; }

		public uint? DEFAULTASSIGNEEINFO { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DESIGNATED { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? FIRSTROUTEDON { get; set; }

		public DateTime? FIRSTROUTEDONGMT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREQUIRED { get; set; }

		public string LASTCOMPLETEDBYID { get; set; }

		public DateTime? LASTCOMPLETEDON { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public DateTime? LASTDESIGNATEDON { get; set; }

		public DateTime? LASTDESIGNATEDONGMT { get; set; }

		public uint? LASTSTAGE { get; set; }

		public string NOTES { get; set; }

		public uint? OUTSTANDINGDETAILSTATUS { get; set; }

		public string PARENTID { get; set; }

		public string PROCESSMODELNAME { get; set; }

		public string REASSIGNMENTCOMMENTS { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STAGE { get; set; }

	}

}
