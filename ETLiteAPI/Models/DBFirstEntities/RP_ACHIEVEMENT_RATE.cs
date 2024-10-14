using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_ACHIEVEMENT_RATE {

		public decimal? ACHIEVERATE { get; set; }

		public string BIZ_BUNAME { get; set; }

		public string FACTORYNAME { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? NACHIEVERATE { get; set; }

	}

}
