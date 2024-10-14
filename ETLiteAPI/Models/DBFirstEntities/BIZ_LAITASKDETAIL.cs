using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LAITASKDETAIL {

		public string BIZ_LAITASKDETAILID { get; set; }

		public string BIZ_CHECKREASONID { get; set; }

		public string BIZ_LAITASKDETAILNAME { get; set; }

		public string BIZ_LAITASKID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCEID { get; set; }

		public string SAMPLETEST { get; set; }

	}

}
