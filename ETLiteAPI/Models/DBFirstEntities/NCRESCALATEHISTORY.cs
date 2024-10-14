using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NCRESCALATEHISTORY {

		public string NCRESCALATEHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public string CONTAINERID { get; set; }

		public string ESCALATEDBYID { get; set; }

		public string ESCALATEDEVENTID { get; set; }

		public DateTime? ESCALATIONDATE { get; set; }

		public DateTime? ESCALATIONDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string NCRCAUSECODEID { get; set; }

		public string NCRCOMMENT { get; set; }

		public string NCRRESOLUTIONCODEID { get; set; }

		public string NONCONFORMANCEREPORTID { get; set; }

		public string ORGANIZATIONID { get; set; }

		public string PRIORITYLEVELID { get; set; }

		public string QUALITYOBJECTID { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public string TXNID { get; set; }

	}

}
