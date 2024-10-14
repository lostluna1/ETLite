using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HVSETUPHISTORYDETAIL {

		public string HVSETUPHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPID { get; set; }

		public string COMPNAME { get; set; }

		public string HISTORYID { get; set; }

		public string HVSETUPHISTORYDETAILNAME { get; set; }

		public string LOTNO { get; set; }

		public string PARENTID { get; set; }

		public string PRODUCTID { get; set; }

		public uint? SLOT { get; set; }

		public uint? SUBSLOT { get; set; }

		public string TXNID { get; set; }

	}

}
