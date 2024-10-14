using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_SMTMACHINELOCS {

		public string BIZ_SMTMACHINELOCSID { get; set; }

		public string BIZ_SMTMACHINECODEID { get; set; }

		public string BIZ_SMTMACHINELOCID { get; set; }

		public string BIZ_SMTMACHINELOCSNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
