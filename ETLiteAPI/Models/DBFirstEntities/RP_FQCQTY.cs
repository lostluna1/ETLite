using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_FQCQTY {

		public string FACTORYNAME { get; set; }

		public decimal? FQCNGQTY1 { get; set; }

		public decimal? FQCPASSQTY { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

	}

}
