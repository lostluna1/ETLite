using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBTXNHISTORY {

		public string JOBTXNHISTORYID { get; set; }

		public uint? ACKNOWLEDGECOUNT { get; set; }

		public uint? ASSIGNCOUNT { get; set; }

		public string CAUSECODEID { get; set; }

		public string CAUSECODENAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHECKLISTONLY { get; set; }

		public uint? CLOCKONCOUNT { get; set; }

		public decimal? ESTIMATEDDURATION { get; set; }

		public DateTime? EXPECTEDSTARTDATE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMJOBSTATUS { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string JOBID { get; set; }

		public string JOBMODELID { get; set; }

		public string JOBMODELNAME { get; set; }

		public string JOBORDERID { get; set; }

		public string JOBORDERNAME { get; set; }

		public string JOBSTATUS { get; set; }

		public string REPAIRCODEID { get; set; }

		public string REPAIRCODENAME { get; set; }

		public string STAGEID { get; set; }

		public string STAGENAME { get; set; }

		public uint? STAGESEQUENCE { get; set; }

		public string SYMPTOMCODEID { get; set; }

		public string SYMPTOMCODENAME { get; set; }

		public string TOSTAGEID { get; set; }

		public string TOSTAGENAME { get; set; }

		public uint? TOSTAGESEQUENCE { get; set; }

		public string TXNID { get; set; }

	}

}
