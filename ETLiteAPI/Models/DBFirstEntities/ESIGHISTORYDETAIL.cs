using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESIGHISTORYDETAIL {

		public string ESIGHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string COSIGNERFULLNAME { get; set; }

		public string COSIGNERID { get; set; }

		public string COSIGNREASONID { get; set; }

		public string ESIGHISTORYSUMMARYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string SIGNERFULLNAME { get; set; }

		public string SIGNERID { get; set; }

		public string TXNID { get; set; }

	}

}
