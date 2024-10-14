using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CAPAHISTORYDETAIL {

		public string CAPAHISTORYDETAILID { get; set; }

		public string BRIEFDESCRIPTION { get; set; }

		public string CARSEVERITYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMHISTORYDETAILID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string INITIATORID { get; set; }

		public string INITIATORORGANIZATIONID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISSYSTEMICISSUE { get; set; }

		public DateTime? OCCURRENCEDATE { get; set; }

		public DateTime? OCCURRENCEDATEGMT { get; set; }

		public string PRIORITYLEVELID { get; set; }

		public string PROPOSEDRESOLUTION { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string REPORTERID { get; set; }

		public string REPORTERORGANIZATIONID { get; set; }

		public string TXNID { get; set; }

	}

}
