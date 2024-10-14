using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMBINEHISTORYDETAIL {

		public string COMBINEHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOSEWHENEMPTY { get; set; }

		public uint? COMBINEALLQTY { get; set; }

		public string COMBINEHISTORYID { get; set; }

		public uint? CONTAINERCLOSED { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string TXNID { get; set; }

	}

}
