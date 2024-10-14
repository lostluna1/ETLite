using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIAPPROVALCYCLEVIEW {

		public string APPROVALCYCLE { get; set; }

		public string APPROVEDBY { get; set; }

		public string COMMENTS { get; set; }

		public DateTime? COMPLETEBYGMT { get; set; }

		public string DECISIONTYPE { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string GENERALINSTRUCTIONS { get; set; }

		public string ID { get; set; }

		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		public DateTime? LASTROUTEDONGMT { get; set; }

		public string NAME { get; set; }

		public string ROLENAME { get; set; }

		public uint? SHEETLEVEL { get; set; }

		public string SPECIALINSTRUCTIONS { get; set; }

		public string STATUS { get; set; }

	}

}
