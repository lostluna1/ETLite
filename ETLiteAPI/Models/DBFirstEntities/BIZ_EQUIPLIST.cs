using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_EQUIPLIST {

		public string BIZ_EQUIPLISTID { get; set; }

		public string BIZ_EQUIPBORROWTASKID { get; set; }

		public string BIZ_EQUIPLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARTID { get; set; }

		public string RESOURCEID { get; set; }

		public string TOOLID { get; set; }

	}

}
