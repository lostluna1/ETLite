using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_MFGORDERMATERIALLISTITEMSUB {

		public uint FIELDID { get; set; }

		public string MFGORDERMATERIALLISTITEMID { get; set; }

		public uint SEQUENCE { get; set; }

		public string SUBSTITUTESBASEID { get; set; }

		public string SUBSTITUTESID { get; set; }

	}

}
