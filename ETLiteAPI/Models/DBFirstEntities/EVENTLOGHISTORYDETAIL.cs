using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTLOGHISTORYDETAIL {

		public string EVENTLOGHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string COMMENTTYPEID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EVENTDATAHISTORYDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string TXNID { get; set; }

	}

}
