using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELEGATETASKHISTORY {

		public string DELEGATETASKHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string DELEGATETASKHISTORYNAME { get; set; }

		public string DELEGATIONREASONCODEID { get; set; }

		public string DELEGATIONTARGETID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string SOURCEEMPLOYEEID { get; set; }

		public string TARGETEMPLOYEEID { get; set; }

		public string TXNID { get; set; }

	}

}
