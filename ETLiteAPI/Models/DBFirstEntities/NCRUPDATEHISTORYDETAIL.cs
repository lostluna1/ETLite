using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NCRUPDATEHISTORYDETAIL {

		public string NCRUPDATEHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public string CORRECTIVEACTIONHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FAILUREINVESTIGATIONHISTORYID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISPREHISTORY { get; set; }

		public string NCRCAUSECODEID { get; set; }

		public string NCRCOMMENT { get; set; }

		public string NCRFAILURETYPEID { get; set; }

		public string NCRRESOLUTIONID { get; set; }

		public string NCRUPDATEHISTORYID { get; set; }

		public string PREVENTIVEACTIONHISTORYID { get; set; }

		public string RELATEDNONCONFORMANCEID { get; set; }

		public string TXNID { get; set; }

	}

}
