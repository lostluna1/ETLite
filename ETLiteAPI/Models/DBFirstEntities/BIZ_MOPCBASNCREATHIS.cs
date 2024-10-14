using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MOPCBASNCREATHIS {

		public string BIZ_MOPCBASNCREATHISID { get; set; }

		public string BIZ_MOPCBASNCREATHISNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CREATEMPLOYEEID { get; set; }

		public DateTime? CREATTIME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MATERIALLOTID { get; set; }

		public string MFGORDERID { get; set; }

		public decimal? PANELQTY { get; set; }

		public string PCBSIDE { get; set; }

		public uint? PRIORITY { get; set; }

		public decimal? QTY { get; set; }

		public string TXNID { get; set; }

	}

}
