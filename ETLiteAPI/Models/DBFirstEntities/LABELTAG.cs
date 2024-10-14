using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class LABELTAG {

		public string LABELTAGID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DEFAULTVALUE { get; set; }

		public uint? DEPTH { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string EXPRESSION { get; set; }

		public string HIERARCHICALRELATION { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLIST { get; set; }

		public string LABELTAGNAME { get; set; }

		public string LISTITEMEXPRESSION { get; set; }

		public string PRINTERLABELDEFINITIONID { get; set; }

	}

}
