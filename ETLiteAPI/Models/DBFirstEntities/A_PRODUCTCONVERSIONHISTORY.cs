using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PRODUCTCONVERSIONHISTORY {

		public string PRODUCTCONVERSIONHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMPRODUCTID { get; set; }

		public string FROMWORKFLOWID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PRODUCTCONVERSIONPLANID { get; set; }

		public string TOPRODUCTFORCHILDID { get; set; }

		public string TOPRODUCTID { get; set; }

		public string TOWORKFLOWID { get; set; }

		public string TXNID { get; set; }

	}

}
