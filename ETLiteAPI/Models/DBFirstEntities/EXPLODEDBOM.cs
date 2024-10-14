using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXPLODEDBOM {

		public string COMPONENTLEVEL { get; set; }

		public string COMPONENTQTY { get; set; }

		public string COMPONENTREV { get; set; }

		public string COMPONENTUOM { get; set; }

		public string CONTAINERID { get; set; }

		public DateTime? EFFECTIVEFROM { get; set; }

		public DateTime? EFFECTIVETHRU { get; set; }

		public string ISSUETYPE { get; set; }

		public string MATERIAL { get; set; }

		public string OVERCONSUMPTION { get; set; }

		public string PHANTOM { get; set; }

		public decimal? RECID { get; set; }

		public string SUBSTITUTION { get; set; }

		public string UNDERCONSUMPTION { get; set; }

	}

}
