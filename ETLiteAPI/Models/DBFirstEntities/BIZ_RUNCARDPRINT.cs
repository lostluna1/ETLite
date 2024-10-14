using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_RUNCARDPRINT {

		public string BIZ_RUNCARDPRINTID { get; set; }

		public string BARTENDERURL { get; set; }

		public string BIZ_RUNCARDPRINTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLOR { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string FATHERMFGORDERID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? LABELCOUNT { get; set; }

		public string LABELTEMPLATE { get; set; }

		public string LENGTH { get; set; }

		public string MFGORDERID { get; set; }

		public uint? PRINTCOUNT { get; set; }

		public string PRINTER { get; set; }

		public string PRINTINGCONTENT { get; set; }

		public string PRODUCTCODE { get; set; }

		public decimal? QTY { get; set; }

		public string TOPMFGORDERID { get; set; }

		public string TXNID { get; set; }

		public string WARENUM { get; set; }

	}

}
