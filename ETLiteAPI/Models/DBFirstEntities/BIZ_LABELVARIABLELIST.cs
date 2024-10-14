using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LABELVARIABLELIST {

		public string BIZ_LABELVARIABLELISTID { get; set; }

		public string BIZ_LABELDEFINITIONID { get; set; }

		public string BIZ_LABELVARIABLELISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string REMARK { get; set; }

		public string VARIABLENAME { get; set; }

		public string VARIABLEVALUE { get; set; }

	}

}
