using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ATETESTWORKFLOW {

		public string ATETESTWORKFLOWID { get; set; }

		public string ATETESTWORKFLOWNAME { get; set; }

		public string ATETESTWORKSTATION { get; set; }

		public string BIZ_PRODUCTCATAGORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MESSPECID { get; set; }

		public uint? TESTSEQUENCE { get; set; }

	}

}
