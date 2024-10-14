using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHGOBJECTLISTHISTORYDETAILS {

		public string CHGATTRHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHGATTRHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FIELDID { get; set; }

		public string FIELDNAME { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string NEWDISPLAYVALUE { get; set; }

		public string OLDDISPLAYVALUE { get; set; }

		public string TXNID { get; set; }

	}

}
