using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_AFERPROCESSINGHSG {

		public string BIZ_AFERPROCESSINGHSGID { get; set; }

		public string BIZ_AFERPROCESSINGHSGNAME { get; set; }

		public string BIZ_AFTERHSGRFIDLISTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string TXNID { get; set; }

		public string WOID { get; set; }

	}

}
