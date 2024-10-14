using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_PRODEFFVIEW {

		public decimal? ACTIVATION_RATE { get; set; }

		public DateTime? CALENDARDAY { get; set; }

		public string MFGLINENAME { get; set; }

		public string MONTH_OF_YEAR { get; set; }

		public decimal? PRDRATE { get; set; }

		public string WEEK_OF_YEAR { get; set; }

		public decimal? WORKRATE { get; set; }

	}

}
