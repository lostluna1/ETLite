using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISDEFECTMAP {

		public string ISDEFECTMAPID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ISDEFECTLABEL { get; set; }

		public string ISDEFECTMAPNAME { get; set; }

		public string ISDEFECTMAPPINGID { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISIGNOREDEFECT { get; set; }

	}

}
