﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DOCATTACHMENTSHISTORY {

		public string DOCATTACHMENTSHISTORYID { get; set; }

		public string ATTACHMENTSOWNERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string OBJECTNAME { get; set; }

		public string OBJECTREV { get; set; }

		public uint? OBJECTTYPE { get; set; }

		public string PARENTDISPLAYNAME { get; set; }

		public string TXNID { get; set; }

	}

}
