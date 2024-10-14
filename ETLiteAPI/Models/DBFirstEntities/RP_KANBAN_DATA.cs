using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_KANBAN_DATA {

		public string BIZ_CUSTOMERPRODUCT { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public decimal? COMPLETEQTY { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? FQCNGQTY { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PRODUCTNAME1 { get; set; }

		public decimal? TESTQTYS { get; set; }

		public decimal? WOQTY { get; set; }

	}

}
