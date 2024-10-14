using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CONTAINERRENAMEHISTDETAIL {

		public string CONTAINERRENAMEHISTDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHGCONTAINERATTRHISTORYID { get; set; }

		public string CONTAINERRENAMEHISTDETAILNAME { get; set; }

		public string HISTORYID { get; set; }

		public uint? ISPREHISTORY { get; set; }

		public string NAME { get; set; }

		public string TXNID { get; set; }

	}

}
