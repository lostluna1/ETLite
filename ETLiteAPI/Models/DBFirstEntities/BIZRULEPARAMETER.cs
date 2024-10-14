using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZRULEPARAMETER {

		public string BIZRULEPARAMETERID { get; set; }

		public string BUSINESSRULEDATAID { get; set; }

		public string BUSINESSRULEHANDLERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PARAMSPECID { get; set; }

		public string VALUEEXPRESSION { get; set; }

	}

}
