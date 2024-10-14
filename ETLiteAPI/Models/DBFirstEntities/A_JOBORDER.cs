using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBORDER {

		public string JOBORDERID { get; set; }

		public uint? BIZ_ACTURALWORKINGHOUR { get; set; }

		public string BIZ_EQUIPIMRSUPID { get; set; }

		public string BIZ_EQUIPIMRTECHID { get; set; }

		public string BIZ_EQUIPREPAIREXPENSETYPEID { get; set; }

		public uint? BIZ_ORDERWORKINGHOUR { get; set; }

		public string BIZ_REPAIRINGAPPLICANTID { get; set; }

		public string BIZ_REPAIRINGATTACH { get; set; }

		public string BIZ_REPAIRINGPO { get; set; }

		public string BIZ_REPAIRINGREMARK { get; set; }

		public string BIZ_REPAIRINGVENDOR { get; set; }

		public DateTime? BIZ_TASKCLOSETIME { get; set; }

		public DateTime? BIZ_TASKSTARTTIME { get; set; }

		public string BIZ_TASKSTATUSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBCAUSECODEID { get; set; }

		public string JOBMODELID { get; set; }

		public string JOBORDERNAME { get; set; }

		public string JOBREPAIRCODEID { get; set; }

		public string JOBSYMPTOMCODEID { get; set; }

		public string NOTES { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
