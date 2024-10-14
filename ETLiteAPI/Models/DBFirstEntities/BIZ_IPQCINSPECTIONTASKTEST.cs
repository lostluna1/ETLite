using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_IPQCINSPECTIONTASKTEST {

		public string BIZ_IPQCINSPECTIONTASKTESTID { get; set; }

		public string BIZ_IPQCINSPECTIONTASKID { get; set; }

		public string BIZ_IPQCINSPECTIONTASKTESTNAME { get; set; }

		public string BIZ_IPQCSHIFTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCEID { get; set; }

		public string SAMPLETEST { get; set; }

	}

}
