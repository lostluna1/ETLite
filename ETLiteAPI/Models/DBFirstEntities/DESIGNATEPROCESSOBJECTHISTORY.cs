using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DESIGNATEPROCESSOBJECTHISTORY {

		public string DESIGNATEPROCESSOBJECTHISTORID { get; set; }

		public uint? ASSIGNEEOPTION { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMROLEID { get; set; }

		public string FROMUSERID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string PROCESSOBJECTID { get; set; }

		public string QUALITYOBJECTID { get; set; }

		public string TOROLEID { get; set; }

		public string TOUSERID { get; set; }

		public string TXNID { get; set; }

	}

}
