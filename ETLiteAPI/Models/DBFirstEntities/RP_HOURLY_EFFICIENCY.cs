using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_HOURLY_EFFICIENCY {

		public decimal? ACTUALOUTPUT { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public string BREAKTIME { get; set; }

		public string ENDTIME { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? FQCNGQTY { get; set; }

		public decimal? FQCPASSQTY { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? NGQTY { get; set; }

		public decimal? PLANNEDOUTPUT { get; set; }

		public string SHIFTBACKQTY { get; set; }

		public decimal? SHIFTCOMPLATEQTY { get; set; }

		public string STARTTIME { get; set; }

	}

}
