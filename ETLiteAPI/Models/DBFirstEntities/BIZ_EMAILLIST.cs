using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_EMAILLIST {

		public string BIZ_EMAILLISTID { get; set; }

		public string BIZ_EMAILLISTNAME { get; set; }

		public string BIZ_EMAILURL { get; set; }

		public string BIZ_REMARK { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string TOOLID { get; set; }

	}

}
