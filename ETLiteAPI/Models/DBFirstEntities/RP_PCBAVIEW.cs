using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_PCBAVIEW {

		public decimal? COMQTY { get; set; }

		public decimal? DIFF { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public decimal? QTY { get; set; }

		public DateTime? TXTDATE { get; set; }

		public decimal? WOQTY { get; set; }

	}

}
