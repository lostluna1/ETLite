using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_HISTORYMAINLINECHILDDETAILS {

		public string HISTORYMAINLINECHILDDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHILDCONTAINERID { get; set; }

		public string CHILDCONTAINERNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public decimal? MOVEINQTY { get; set; }

		public decimal? MOVEINQTY2 { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
