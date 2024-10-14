using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISCONSUMEMATQUEUETXNS {

		public string ISCONSUMEMATQUEUETXNSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string FACTORYID { get; set; }

		public string ISCONSUMEMATQUEUETXNSNAME { get; set; }

		public string ISCONSUMEONTXN { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
