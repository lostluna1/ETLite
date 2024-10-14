using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_MAINTENANCESTATUSCHECKLIST {

		public string MAINTENANCESTATUSCHECKLISTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHECKLISTACTION { get; set; }

		public string CHECKLISTID { get; set; }

		public string COMMENTS { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string INSTRUCTION { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MAINTENANCESTATUSID { get; set; }

		public DateTime? TXNDATE { get; set; }

	}

}
