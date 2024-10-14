using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRACTIVITYLOG {

		public string CDONAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_RECIPEID { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string FACTORYNAME { get; set; }

		public string OPERATIONNAME { get; set; }

		public uint? REVERSALSTATUS { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
