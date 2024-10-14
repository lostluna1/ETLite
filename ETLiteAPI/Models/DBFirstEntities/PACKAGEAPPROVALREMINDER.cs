using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class PACKAGEAPPROVALREMINDER {

		public string PACKAGEAPPROVALREMINDERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DAYSAFTERDUE { get; set; }

		public uint? DAYSBEFOREDUE { get; set; }

		public string EMAILMESSAGEID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISREPEATDAILY { get; set; }

		public string PACKAGEAPPROVALREMINDERNAME { get; set; }

		public string PARENTID { get; set; }

		public uint? RECIPIENT { get; set; }

	}

}
