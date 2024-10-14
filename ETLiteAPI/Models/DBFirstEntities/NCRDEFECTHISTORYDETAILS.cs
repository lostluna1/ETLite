using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NCRDEFECTHISTORYDETAILS {

		public string NCRDEFECTHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISSUEACTUALSHISTORYID { get; set; }

		public string LOT { get; set; }

		public string PRODUCTID { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string SERVICEHISTORYSUMMARYID { get; set; }

		public string TXNID { get; set; }

	}

}
