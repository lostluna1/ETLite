﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISVALIDATEMATQUEUETXNS {

		public string ISVALIDATEMATQUEUETXNSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string FACTORYID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISVALIDATEMATQUEUETXNSNAME { get; set; }

		public string ISVALIDATEONTXN { get; set; }

	}

}
