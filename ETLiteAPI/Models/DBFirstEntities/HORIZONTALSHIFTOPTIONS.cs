using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HORIZONTALSHIFTOPTIONS {

		public string HORIZONTALSHIFTOPTIONSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? HORIZONTALSHIFTDIRECTION { get; set; }

		public uint? HORIZONTALSHIFTVALUE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string UIACTIONID { get; set; }

	}

}
