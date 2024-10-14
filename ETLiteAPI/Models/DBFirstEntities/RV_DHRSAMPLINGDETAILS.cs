using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRSAMPLINGDETAILS {

		public string AQLLEVELNAME { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DATAVALUE { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string INSPECTIONLEVELNAME { get; set; }

		public string LOSSREASONNAME { get; set; }

		public string SAMPLETESTNAME { get; set; }

		public string SAMPLETYPE { get; set; }

		public string SAMPLINGPLANNAME { get; set; }

		public string SAMPLINGSTATUS { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

	}

}
