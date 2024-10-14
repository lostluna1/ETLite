using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTCOMPONENT {

		public string EVENTCOMPONENTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EVENTLOTID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string LOT { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREV { get; set; }

	}

}
