using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EFFICIENCY {

		public string FACTORYNAME { get; set; }

		public string MANPOWER { get; set; }

		public decimal? MFGEFFICIENCY { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? NMFGEFFICIENCY { get; set; }

	}

}
