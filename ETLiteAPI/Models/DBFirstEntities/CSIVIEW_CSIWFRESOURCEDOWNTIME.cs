using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIVIEW_CSIWFRESOURCEDOWNTIME {

		public uint? AVAILABILITY { get; set; }

		public string CONTAINERID { get; set; }

		public DateTime? LASTACTIVITYDATE { get; set; }

		public DateTime? LASTSTATUSCHANGEDATE { get; set; }

		public string MFGORDERID { get; set; }

		public string REASONID { get; set; }

		public string RESOURCEGROUPNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public uint? RESOURCESTATE { get; set; }

		public string RESOURCESTATUSCODENAME { get; set; }

		public string RESOURCESTATUSREASONNAME { get; set; }

		public string SPECID { get; set; }

		public string STATUSID { get; set; }

		public string TIMEDOWN { get; set; }

		public string WORKFLOWID { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public string WORKFLOWSTEPID { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
