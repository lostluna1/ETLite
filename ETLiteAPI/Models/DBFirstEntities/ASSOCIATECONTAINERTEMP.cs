using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ASSOCIATECONTAINERTEMP {

		public string ASSOCIATEHISTORYID { get; set; }

		public uint? ASSOCIATESEQ { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string CURRENTCROSSREFSID { get; set; }

		public string CURRENTSTATUSID { get; set; }

		public string NEWCURRENTSTATUSID { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string STEPPASSCOUNTID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
