using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SERIALIZEHISTORYDETAILS {

		public string SERIALIZEHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHILDCONTAINERLEVELID { get; set; }

		public uint? CHILDCOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PRODUCTID { get; set; }

		public string SERIALIZEHISTORYID { get; set; }

		public string TXNID { get; set; }

	}

}
