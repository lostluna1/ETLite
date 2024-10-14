using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_COMPONENTREMOVEDETAILSLITE {

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string FROMCONTAINERNAME { get; set; }

		public string FROMLOT { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

	}

}
