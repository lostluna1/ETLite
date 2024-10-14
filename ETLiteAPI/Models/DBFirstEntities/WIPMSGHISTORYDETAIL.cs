using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class WIPMSGHISTORYDETAIL {

		public string WIPMSGHISTORYDETAILID { get; set; }

		public uint? ACKNOWLEDGEMENTREQUIRED { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DOCUMENTID { get; set; }

		public string ENTEREDUSERNAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? MSGACKNOWLEDGED { get; set; }

		public string MSGTEXT { get; set; }

		public string PARENTID { get; set; }

		public uint? PASSWORDREQUIRED { get; set; }

		public string TXNID { get; set; }

		public string WIPMSGDETAILSID { get; set; }

	}

}
