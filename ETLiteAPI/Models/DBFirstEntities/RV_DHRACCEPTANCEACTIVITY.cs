using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRACCEPTANCEACTIVITY {

		public string COMMENTS { get; set; }

		public string COMPUTATIONNAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string COSIGNERFULLNAME { get; set; }

		public string DATANAME { get; set; }

		public string DATAVALUE { get; set; }

		public string ELECTRONICPROCEDURENAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string ESIGMEANINGNAME { get; set; }

		public string LOWERLIMIT { get; set; }

		public string NAME { get; set; }

		public string OPERATIONNAME { get; set; }

		public string RESULTVALUE { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SIGNERFULLNAME { get; set; }

		public string TASKITEMNAME { get; set; }

		public string TASKLISTNAME { get; set; }

		public uint? TASKLISTSEQUENCE { get; set; }

		public string TASKSTATUS { get; set; }

		public string TIINSTRUCTION { get; set; }

		public string TIREPORTINSTRUCTION { get; set; }

		public string TLINSTRUCTION { get; set; }

		public string TLREPORTINSTRUCTION { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string UOMNAME { get; set; }

		public string UPPERLIMIT { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
