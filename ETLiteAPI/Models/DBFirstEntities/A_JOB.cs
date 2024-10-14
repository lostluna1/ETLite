using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOB {

		public string JOBID { get; set; }

		public uint? ACKNOWLEDGECOUNT { get; set; }

		public uint? ACTIVECLOCKONCOUNT { get; set; }

		public uint? ASSIGNCOUNT { get; set; }

		public DateTime? CANCELDATE { get; set; }

		public string CANCELUSERID { get; set; }

		public string CAUSECODEID { get; set; }

		public string CAUSECODENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOCKONCOUNT { get; set; }

		public DateTime? COMPLETEDATE { get; set; }

		public string COMPLETEUSERID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public string CREATEUSERID { get; set; }

		public decimal? ESTIMATEDDURATION { get; set; }

		public DateTime? EXPECTEDSTARTDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public DateTime? FIRSTCLOCKONDATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSIMPLEMODE { get; set; }

		public string JOBMODELID { get; set; }

		public string JOBMODELNAME { get; set; }

		public string JOBORDERID { get; set; }

		public string JOBORDERNAME { get; set; }

		public string JOBSTATUS { get; set; }

		public DateTime? LASTCLOCKOFFDATE { get; set; }

		public string LASTINTEGRATIONTXNID { get; set; }

		public string REPAIRCODEID { get; set; }

		public string REPAIRCODENAME { get; set; }

		public string RESOURCEID { get; set; }

		public string STAGEID { get; set; }

		public string STAGENAME { get; set; }

		public uint? STAGESEQUENCE { get; set; }

		public string SYMPTOMCODEID { get; set; }

		public string SYMPTOMCODENAME { get; set; }

	}

}
