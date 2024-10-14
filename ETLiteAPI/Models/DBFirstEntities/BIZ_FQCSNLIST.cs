using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_FQCSNLIST {

		public string BIZ_FQCSNLISTID { get; set; }

		public string BIZ_FQCINSPECTIONTASKID { get; set; }

		public string BIZ_FQCSNLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
