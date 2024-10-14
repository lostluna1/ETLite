using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_ESDBAGLABLEPRINTHISTORY {

		public string BIZ_ESDBAGLABLEPRINTHISTORYID { get; set; }

		public string ATESN { get; set; }

		public string BIZ_ESDBAGLABLEPRINTHISTORNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CPN { get; set; }

		public string DC { get; set; }

		public string ESDBAGLABLESNID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LASTPRINTINGEMPLOYEEID { get; set; }

		public DateTime? LASTPRINTINGTIME { get; set; }

		public string MFGORDERID { get; set; }

		public string MODEL { get; set; }

		public string OPN { get; set; }

		public uint? PRINTINGTIMES { get; set; }

		public string PRODUCTID { get; set; }

		public string TXNID { get; set; }

	}

}
