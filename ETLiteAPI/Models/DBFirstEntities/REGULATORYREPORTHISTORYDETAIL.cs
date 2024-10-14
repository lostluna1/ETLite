using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class REGULATORYREPORTHISTORYDETAIL {

		public string REGULATORYREPORTHISTORYDETAIID { get; set; }

		public string ATTACHMENTREFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CREATEDBYID { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public DateTime? CREATIONDATEGMT { get; set; }

		public DateTime? DUEDATE { get; set; }

		public DateTime? DUEDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PARENTID { get; set; }

		public string REGULATORYAGENCYID { get; set; }

		public string REGULATORYREPORTTYPEID { get; set; }

		public string REPORTNUMBER { get; set; }

		public DateTime? SUBMISSIONDATE { get; set; }

		public DateTime? SUBMISSIONDATEGMT { get; set; }

		public uint? SUBMISSIONREQUIRED { get; set; }

		public string SUBMITTEDBYID { get; set; }

		public string TXNID { get; set; }

	}

}
