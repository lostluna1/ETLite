using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRUNITLOT {

		public string BOMNAME { get; set; }

		public string BOMREVISION { get; set; }

		public string CONTAINERNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string IDENTIFIER { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? MFGORDERQTY { get; set; }

		public decimal? ORIGINALQTY { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public string UOMNAME { get; set; }

	}

}
