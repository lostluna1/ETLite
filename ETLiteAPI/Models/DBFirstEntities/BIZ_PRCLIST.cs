using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PRCLIST {

		public string BIZ_PRCLISTID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COLUMN671090794 { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

	}

}
