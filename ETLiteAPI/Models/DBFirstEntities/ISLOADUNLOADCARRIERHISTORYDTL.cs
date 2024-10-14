using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISLOADUNLOADCARRIERHISTORYDTL {

		public string ISLOADUNLOADCARRIERHISTORYDTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISLOADUNLOADCARRIERHISTORYNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? SLOTPOSITION { get; set; }

		public string TXNID { get; set; }

	}

}
