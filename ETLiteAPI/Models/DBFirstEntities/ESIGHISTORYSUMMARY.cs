using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESIGHISTORYSUMMARY {

		public string ESIGHISTORYSUMMARYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COSIGNERROLEID { get; set; }

		public string ESIGREQDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MEANINGID { get; set; }

		public string ROLEID { get; set; }

		public uint? SIGNATURECOUNT { get; set; }

		public string TXNID { get; set; }

		public uint? VERIFICATIONMETHOD { get; set; }

	}

}
