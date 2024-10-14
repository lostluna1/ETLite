using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class APPROVALDECISION {

		public string APPROVALDECISIONID { get; set; }

		public string APPROVALDECISIONLISTID { get; set; }

		public string APPROVALDECISIONNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? DECISIONTYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? INCLUDECOMMENTS { get; set; }

		public uint? ISFROZEN { get; set; }

	}

}
