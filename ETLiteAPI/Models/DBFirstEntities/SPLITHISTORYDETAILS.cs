using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SPLITHISTORYDETAILS {

		public string SPLITHISTORYDETAILSID { get; set; }

		public uint? ADJUSTTHRUPUT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string SPLITHISTORYID { get; set; }

		public string TOCONTAINERID { get; set; }

		public string TOPRODUCTID { get; set; }

		public string TXNID { get; set; }

		public uint? UNITCOUNT { get; set; }

	}

}
