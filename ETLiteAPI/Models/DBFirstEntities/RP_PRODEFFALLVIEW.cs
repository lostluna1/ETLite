using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_PRODEFFALLVIEW {

		public decimal? ACTIVATION_RATE { get; set; }

		public DateTime? CALENDARDAY { get; set; }

		public string DESCRIPTION { get; set; }

		public string FACTORYNAME { get; set; }

		public string MFGLINENAME { get; set; }

		public decimal? PRDRATE { get; set; }

		public decimal? VAR1 { get; set; }

		public decimal? VAR2 { get; set; }

		public decimal? VAR3 { get; set; }

		public decimal? VAR4 { get; set; }

		public decimal? VAR5 { get; set; }

		public decimal? VAR6 { get; set; }

		public decimal? VAR7 { get; set; }

		public decimal? WORKRATE { get; set; }

	}

}
