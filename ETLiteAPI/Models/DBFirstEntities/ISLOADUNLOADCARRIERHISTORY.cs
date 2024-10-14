using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISLOADUNLOADCARRIERHISTORY {

		public string ISLOADUNLOADCARRIERHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISCARRIERID { get; set; }

		public uint? ISCARRIERLOADTYPE { get; set; }

		public string ISLOADUNLOADCARRIERHISTORYNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? TRANSFERCONTAINER { get; set; }

		public string TXNID { get; set; }

		public uint? UNLOADALL { get; set; }

		public uint? USEPOSITION { get; set; }

	}

}
