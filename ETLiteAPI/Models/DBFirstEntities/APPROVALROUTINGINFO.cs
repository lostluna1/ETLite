using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class APPROVALROUTINGINFO {

		public string APPROVALROUTINGINFOID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CLOSEDESCRIPTION { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string PARENTID { get; set; }

		public string QUALITYRESOLUTIONCODEID { get; set; }

		public uint? QUALITYSTATUS { get; set; }

		public uint? RESOLUTIONACTION { get; set; }

	}

}
