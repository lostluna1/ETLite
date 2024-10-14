using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPONENTREPLACEHISTORYDETAIL {

		public string COMPONENTREPLACEHISTORYDETAIID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPONENTREPLACEHISTORYDETNAME { get; set; }

		public string HISTORYID { get; set; }

		public string HVREMOVALDETAILSID { get; set; }

		public uint? ISSCRAPREPLACED { get; set; }

		public string ISSUEDETAILSID { get; set; }

		public string PARENTID { get; set; }

		public string REMOVALDETAILSID { get; set; }

		public string REPLACEREASONID { get; set; }

		public string SUBSTITUTIONREASONID { get; set; }

		public string TXNID { get; set; }

	}

}
