using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DPCOLLECTIONPOINTHISTORY {

		public string DPCOLLECTIONPOINTHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DATATYPE { get; set; }

		public string DPCOLLECTIONGROUPHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INNERLOWERLIMIT { get; set; }

		public string INNERUPPERLIMIT { get; set; }

		public uint? MINIMUMSAMPLES { get; set; }

		public string NAME { get; set; }

		public string OUTERLOWERLIMIT { get; set; }

		public string OUTERUPPERLIMIT { get; set; }

		public string POINTID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string TXNID { get; set; }

		public string UOMID { get; set; }

	}

}
