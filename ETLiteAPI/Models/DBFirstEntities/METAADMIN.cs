using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class METAADMIN {

		public uint METAID { get; set; }

		public uint? CLIENTVALUE { get; set; }

		public string MASTERTAG { get; set; }

		public uint? MASTERVALUE { get; set; }

		public string TABLENAME { get; set; }

	}

}
