using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_MOVE_HISTORY {

		public string CONTAINER { get; set; }

		public string CONTAINER_ID { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public string EMPLOYEE_DESC { get; set; }

		public string EMPLOYEE_NAME { get; set; }

		public string MFGORDER_NAME { get; set; }

		public string NG_QTY { get; set; }

		public decimal? PASS_QTY { get; set; }

		public string PRODUCT_DESC { get; set; }

		public string PRODUCT_NAME { get; set; }

		public string RESOURCE_DESC { get; set; }

		public string RESOURCE_NAME { get; set; }

		public string SPEC_DESC { get; set; }

		public string SPEC_NAME { get; set; }

		public uint? SPEC_SEQUENCE { get; set; }

		public DateTime? TXNDATE { get; set; }

		public decimal? WO_QTY { get; set; }

	}

}
