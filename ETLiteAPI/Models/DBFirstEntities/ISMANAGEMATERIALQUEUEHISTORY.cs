using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMANAGEMATERIALQUEUEHISTORY {

		public string ISMANAGEMATERIALQUEUEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISACTIVE { get; set; }

		public string ISMANAGEMATERIALQUEUEHISTONAME { get; set; }

		public string ISMATERIALQUEUEID { get; set; }

		public string ISMFGORDERID { get; set; }

		public string ISPRODUCTID { get; set; }

		public string ISRESOURCEID { get; set; }

		public string TXNID { get; set; }

	}

}
