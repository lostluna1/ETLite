using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DPCOLLECTIONGROUPHISTORY {

		public string DPCOLLECTIONGROUPHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLLECTDATAPOINTSHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string GROUPID { get; set; }

		public uint? GROUPLAYOUT { get; set; }

		public string HISTORYID { get; set; }

		public uint? MINIMUMSAMPLES { get; set; }

		public string NAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string TXNID { get; set; }

	}

}
