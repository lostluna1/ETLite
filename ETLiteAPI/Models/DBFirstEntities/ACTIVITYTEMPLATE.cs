using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ACTIVITYTEMPLATE {

		public string ACTIVITYTEMPLATEID { get; set; }

		public string ACTIVITYTEMPLATENAME { get; set; }

		public uint? ALLOWREASSIGNMENT { get; set; }

		public uint? APPROVALREQUIRED { get; set; }

		public string ASSIGNEEID { get; set; }

		public uint? ASSIGNEEOPTION { get; set; }

		public string ASSIGNEEROLEID { get; set; }

		public uint? AUTOCOMPLETE { get; set; }

		public uint? AUTOEXECUTE { get; set; }

		public uint? AUTOSTART { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CHECKLISTID { get; set; }

		public uint? COMPLETEWITHINQTY { get; set; }

		public decimal? COMPLETEWITHINUOM { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public uint? DEFAULTASSIGNEEINFO { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPLAYCONFORMINGQUANTITY { get; set; }

		public string DISPOSITIONID { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREQUIRED { get; set; }

		public string NOTES { get; set; }

		public uint? RECONCILEQUANTITY { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

	}

}
