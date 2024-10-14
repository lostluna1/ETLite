using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EXECUTECHECKLISTHISTORYDTL {

		public string EXECUTECHECKLISTHISTORYDTLID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTENTRYID { get; set; }

		public string CHECKLISTTEXT { get; set; }

		public string EXECUTECHECKLISTHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string RESPONSESETID { get; set; }

		public string TXNID { get; set; }

		public string USERCOMMENTS { get; set; }

	}

}
