using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UIVIRPAGEUSERPERSONALIZATIONS {

		public uint FIELDID { get; set; }

		public uint SEQUENCE { get; set; }

		public string UIVIRTUALPAGEID { get; set; }

		public string USERPERSONALIZATIONSID { get; set; }

	}

}
