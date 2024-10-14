using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BUSINESSRULEDATA {

		public string BUSINESSRULEDATAID { get; set; }

		public uint? ALWAYSEXECUTE { get; set; }

		public string BUSINESSRULECONDITION { get; set; }

		public string BUSINESSRULEDATANAME { get; set; }

		public string BUSINESSRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CONTEXTTYPE { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? SCOPE { get; set; }

	}

}
