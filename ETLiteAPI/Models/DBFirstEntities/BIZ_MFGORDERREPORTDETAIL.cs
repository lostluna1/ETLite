using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MFGORDERREPORTDETAIL {

		public string BIZ_MFGORDERREPORTDETAILID { get; set; }

		public string BIZ_MFGORDERREPORTDETAILNAME { get; set; }

		public string CATEGORY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MANPOWER { get; set; }

		public string MANTIME { get; set; }

		public string PARENTID { get; set; }

		public string REMARK { get; set; }

		public string TXNID { get; set; }

	}

}
