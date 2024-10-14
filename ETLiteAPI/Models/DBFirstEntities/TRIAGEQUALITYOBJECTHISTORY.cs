using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TRIAGEQUALITYOBJECTHISTORY {

		public string ESCALATEQUALITYOBJECTHISTORYID { get; set; }

		public uint? CATEGORY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISCARREQUIREDTOCLOSE { get; set; }

		public string PRIORITYLEVELID { get; set; }

		public string PROCESSMODELTEMPLATEID { get; set; }

		public string QUALITYOBJECTOWNERID { get; set; }

		public string QUALITYOBJECTROLEID { get; set; }

		public uint? ROUTEPROCESSMODEL { get; set; }

		public uint? TRIAGECOMPLETE { get; set; }

		public string TRIAGESPECDETAILID { get; set; }

		public string TXNID { get; set; }

	}

}
