using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_METGNOLIST {

		public string BIZ_METGNOLISTID { get; set; }

		public string BIZ_METGNOID { get; set; }

		public string BIZ_METGNOLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? COMBIN_QUANTITY { get; set; }

		public decimal? COMBINE_QUALITY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISVALID { get; set; }

		public string ZFORMAT { get; set; }

	}

}
