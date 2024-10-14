using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISSUEDHIERARCHY {

		public string CUSTOMERNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string FROMCONTAINERNAME { get; set; }

		public string PRODUCTDESCRIPTION { get; set; }

		public string PRODUCTFAMILY { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public string PRODUCTTYPE { get; set; }

		public decimal? QTY { get; set; }

		public string QTYUOM { get; set; }

		public decimal? RECURSELEVEL { get; set; }

		public string TOCONTAINERNAME { get; set; }

		public string TOPLEVELCONTAINERNAME { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
