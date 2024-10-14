using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QUALITYCROSSREFHISTORY {

		public string QUALITYCROSSREFHISTORYID { get; set; }

		public uint? CARRESOLUTIONACTION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CLOSEDESCRIPTION { get; set; }

		public uint? CLOSEREFERENCE { get; set; }

		public string CROSSREFERENCEID { get; set; }

		public uint? EXECUTEACTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string QUALITYRESOLUTIONCODEID { get; set; }

		public string TRACKINGID { get; set; }

		public string TXNID { get; set; }

	}

}
