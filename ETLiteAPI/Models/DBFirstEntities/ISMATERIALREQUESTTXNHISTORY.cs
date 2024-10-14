using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATERIALREQUESTTXNHISTORY {

		public string ISMATERIALREQUESTTXNHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public string ISMATERIALQUEUEID { get; set; }

		public string ISMATERIALREQUESTSTATUSID { get; set; }

		public string ISMATERIALREQUESTTXNHISTORNAME { get; set; }

		public string ISMFGORDERID { get; set; }

		public decimal? LINESIDEQTY { get; set; }

		public string OPERATIONID { get; set; }

		public string REQUESTTYPE { get; set; }

		public string RESOURCEID { get; set; }

		public decimal? STANDARDPACKSIZE { get; set; }

		public string TXNID { get; set; }

	}

}
