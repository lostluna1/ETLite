using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_REGION {

		public int ID { get; set; }

		public string CODE { get; set; }

		public decimal? LAT { get; set; }

		public int? LEVEL { get; set; }

		public decimal? LNG { get; set; }

		public string MERNAME { get; set; }

		public string NAME { get; set; }

		public int? PARENTID { get; set; }

		public string PINYIN { get; set; }

	}

}
