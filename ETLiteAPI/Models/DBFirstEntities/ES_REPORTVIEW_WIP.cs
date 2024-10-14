using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_REPORTVIEW_WIP {

		public string AVGPROCESSTIME { get; set; }

		public decimal? INPROCESSCOUNT { get; set; }

		public decimal? INQUEUECOUNT { get; set; }

		public decimal? ISOPTIONAL { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? ORDERQTY { get; set; }

		public decimal? PROCESSEDCOUNT { get; set; }

		public string PROCESSTIME { get; set; }

		public decimal? STARTEDQTY { get; set; }

		public string STEPDISPLAYNAME { get; set; }

		public decimal? STEPSEQUENCE { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
