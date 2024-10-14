using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBINDEXENTRIES {

		public uint? DBCOLUMNID { get; set; }

		public uint? DBINDEXENTRYID { get; set; }

		public uint? DBINDEXID { get; set; }

		public uint? SEQUENCE { get; set; }

		public uint? SORTORDER { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
