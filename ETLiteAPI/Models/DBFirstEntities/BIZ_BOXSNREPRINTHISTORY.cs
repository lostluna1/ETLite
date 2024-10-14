using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_BOXSNREPRINTHISTORY {

		public string BIZ_BOXSNREPRINTHISTORYID { get; set; }

		public string BIZ_BOXLABLEPRINTHISTORYID { get; set; }

		public string BIZ_BOXSNREPRINTHISTORYNAME { get; set; }

		public string BOXSNID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISWIPLABEL { get; set; }

		public string LABELTEMPLATE { get; set; }

		public string MFGORDERID { get; set; }

		public string PREVIOUSEMPLOYEEID { get; set; }

		public DateTime? PREVIOUSTIME { get; set; }

		public uint? PRINTCOUNT { get; set; }

		public uint? REPRINTCOUNT { get; set; }

		public string TXNID { get; set; }

	}

}
