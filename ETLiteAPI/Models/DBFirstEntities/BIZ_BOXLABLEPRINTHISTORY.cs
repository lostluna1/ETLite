using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_BOXLABLEPRINTHISTORY {

		public string BIZ_BOXLABLEPRINTHISTORYID { get; set; }

		public string BIZ_BOXLABLEPRINTHISTORYNAME { get; set; }

		public string BIZ_BOXSNREPRINTHISTORYID { get; set; }

		public string BOXSNID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERPN { get; set; }

		public string CUSTOMERPO { get; set; }

		public string CUSTOMERREV { get; set; }

		public decimal? GROSSWEIGHT { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISREPRINT { get; set; }

		public uint? ISWIPLABEL { get; set; }

		public string LABELTEMPLATE { get; set; }

		public string LASTPRINTINGEMPLOYEEID { get; set; }

		public DateTime? LASTPRINTINGTIME { get; set; }

		public string MFGORDERID { get; set; }

		public decimal? NETWEIGHT { get; set; }

		public uint? PRINTINGTIMES { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public string TXNID { get; set; }

	}

}
