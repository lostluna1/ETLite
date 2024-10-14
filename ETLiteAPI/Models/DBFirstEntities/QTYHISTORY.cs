using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QTYHISTORY {

		public string QTYHISTORYID { get; set; }

		public string BATCHID { get; set; }

		public string CARRIERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOSEWHENZERO { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISCHARGETORESOURCEID { get; set; }

		public string MASTERRECIPEID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string RESOURCEID { get; set; }

		public string ROLLUPREASONID { get; set; }

		public string THRUPUTREPORTINGLEVELID { get; set; }

		public uint? THRUPUTSUMMARY { get; set; }

		public string TXNID { get; set; }

		public uint? UNITSLOST { get; set; }

	}

}
