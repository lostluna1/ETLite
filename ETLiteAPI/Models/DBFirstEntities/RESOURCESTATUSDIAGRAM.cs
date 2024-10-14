using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOURCESTATUSDIAGRAM {

		public string RESOURCESTATUSDIAGRAMID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMSTATUSCODEID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string RESOURCESTATUSMODELID { get; set; }

		public uint? STATUS { get; set; }

		public string TOSTATUSCODESID { get; set; }

	}

}
