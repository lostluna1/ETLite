using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ACTIVATECHANGEPKGHISTORY {

		public string ACTIVATECHANGEPKGHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEPACKAGENAME { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string EXPORTIMPORTNAME { get; set; }

		public string HISTORYID { get; set; }

		public uint? IMPORTACTION { get; set; }

		public string MODELINGIMPORTFILE { get; set; }

		public string OVERRIDECOMMENTS { get; set; }

		public uint? OVERRIDEEXECUTED { get; set; }

		public string PARENTID { get; set; }

		public string TXNID { get; set; }

	}

}
