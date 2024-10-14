using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_TOOLLIST {

		public string BIZ_TOOLLISTID { get; set; }

		public string BIZ_EQUIPBINDTASKID { get; set; }

		public string BIZ_TOOLLISTNAME { get; set; }

		public uint? BIZ_USAGE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string TOOLID { get; set; }

	}

}
