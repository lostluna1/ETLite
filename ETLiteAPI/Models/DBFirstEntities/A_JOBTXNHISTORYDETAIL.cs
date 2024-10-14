using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_JOBTXNHISTORYDETAIL {

		public string JOBTXNHISTORYDETAILID { get; set; }

		public uint? ACKNOWLEDGECOUNT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHECKLISTCOUNT { get; set; }

		public string CHECKLISTID { get; set; }

		public uint? CLOCKONCOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string JOBTXNHISTORYID { get; set; }

		public string TECHNICIANID { get; set; }

		public string TECHNICIANNAME { get; set; }

		public uint? TECHNICIANSEQUENCE { get; set; }

		public string TECHNICIANSTATUS { get; set; }

		public string TXNID { get; set; }

	}

}
