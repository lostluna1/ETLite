﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHGATTRHISTORYOLDOBJECTS {

		public string OLDOBJECTSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHGATTRHISTORYDETAILSID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string OBJECTDISPLAYNAME { get; set; }

		public string OBJECTID { get; set; }

		public string TXNID { get; set; }

	}

}
