using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_CUTLIST {

		public string BIZ_CUTLISTID { get; set; }

		public string BIZ_CUTLISTNAME { get; set; }

		public string BIZ_STDTOLFORWIRECUTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? MAXLENTH { get; set; }

		public uint? MINLENTH { get; set; }

		public uint? TOLNEGATIVE { get; set; }

		public string TOLPOSITIVE { get; set; }

	}

}
