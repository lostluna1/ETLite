using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIPAGEFLOWSTATE {

		public string UIPAGEFLOWSTATEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTENT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string OWNERID { get; set; }

		public string QUALITYOBJECTNAME { get; set; }

		public string QUALITYOBJECTTYPE { get; set; }

		public string UIPAGEFLOWID { get; set; }

		public string UIPAGEFLOWSTATENAME { get; set; }

	}

}
