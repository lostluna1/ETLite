using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBTECHNICIAN {

		public string JOBTECHNICIANID { get; set; }

		public uint? ACKNOWLEDGECOUNT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOCKONCOUNT { get; set; }

		public DateTime? CLOCKONDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? FIRSTCLOCKONDATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBID { get; set; }

		public DateTime? LASTCLOCKOFFDATE { get; set; }

		public string TECHNICIANID { get; set; }

		public string TECHNICIANNAME { get; set; }

		public uint? TECHNICIANSEQUENCE { get; set; }

		public string TECHNICIANSTATUS { get; set; }

	}

}
