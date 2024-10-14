using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DPCOLLECTIONSAMPLEHISTORY {

		public string DPCOLLECTIONSAMPLEHISTORYID { get; set; }

		public uint? BOOLEANVALUE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public string CELLNAME { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATAPOINTCOLLECTIONRANGECOLOR { get; set; }

		public string DATAVALUE { get; set; }

		public decimal? DECIMALVALUE { get; set; }

		public string DPCOLLECTIONPOINTSHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public uint? INTEGERVALUE { get; set; }

		public DateTime? TIMESTAMPVALUE { get; set; }

		public string TXNID { get; set; }

	}

}
