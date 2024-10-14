﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DISASSOCIATEHISTORY {

		public string DISASSOCIATEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DISASSOCIATEALL { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PARENTCONTAINERID { get; set; }

		public string TXNID { get; set; }

	}

}
