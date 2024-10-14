using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMANAGEMATQUEUEHISTDETAIL {

		public string ISMANAGEMATQUEUEHISTDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public decimal? ISCONSUMEDQTY { get; set; }

		public string ISCONTAINERID { get; set; }

		public string ISLOT { get; set; }

		public string ISMANAGEMATQUEUEHISTDETAILNAME { get; set; }

		public string ISNAME { get; set; }

		public string ISPRODUCTID { get; set; }

		public decimal? ISQTY { get; set; }

		public decimal? ISQTYAVAILABLE { get; set; }

		public uint? ISSEQUENCE { get; set; }

		public string ISUOMID { get; set; }

		public string TXNID { get; set; }

	}

}
