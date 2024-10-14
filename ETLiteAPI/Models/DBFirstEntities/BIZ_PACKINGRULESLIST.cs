using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PACKINGRULESLIST {

		public string BIZ_PACKINGRULESLISTID { get; set; }

		public string BIZ_PACKINGRULESID { get; set; }

		public string BIZ_PACKINGRULESLISTNAME { get; set; }

		public decimal? BOXSTDQTY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CUSTOMERID { get; set; }

		public decimal? HEIGHT { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? LENTH { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? STDQTYPERPALLET { get; set; }

		public decimal? WIDTH { get; set; }

		public decimal? WTOFPACKING { get; set; }

	}

}
