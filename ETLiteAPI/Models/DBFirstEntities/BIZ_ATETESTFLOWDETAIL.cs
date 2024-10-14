using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ATETESTFLOWDETAIL {

		public string BIZ_ATETESTFLOWDETAILID { get; set; }

		public string BIZ_ATESTATIONID { get; set; }

		public string BIZ_ATETESTFLOWDETAILNAME { get; set; }

		public string BIZ_ATETESTFLOWID { get; set; }

		public string BIZ_MODELNAMEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CURRENTSPEC { get; set; }

		public uint? ENABLE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MODELNAME { get; set; }

		public string SPECID { get; set; }

		public string TESTSPEC { get; set; }

	}

}
