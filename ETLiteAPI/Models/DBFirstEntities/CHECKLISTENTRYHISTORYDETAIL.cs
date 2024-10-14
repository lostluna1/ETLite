using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CHECKLISTENTRYHISTORYDETAIL {

		public string CHECKLISTENTRYHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTENTRYID { get; set; }

		public string CHECKLISTTEXT { get; set; }

		public uint? COMMENTSENTRY { get; set; }

		public uint? ENTRYREQUIRED { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string NAME { get; set; }

		public string PARENTID { get; set; }

		public uint? RESPONSEENTRYCONTROL { get; set; }

		public uint? RESPONSELAYOUT { get; set; }

		public string RESPONSESETID { get; set; }

		public uint? SEQUENCE { get; set; }

		public string TXNID { get; set; }

		public string USERCOMMENTS { get; set; }

	}

}
