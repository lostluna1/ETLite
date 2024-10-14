using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRDATACOLLECTION {

		public string COMMENTS { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DATANAME { get; set; }

		public string DATAVALUE { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string LOWERLIMIT { get; set; }

		public string OPERATIONNAME { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string UOMNAME { get; set; }

		public string UPPERLIMIT { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
