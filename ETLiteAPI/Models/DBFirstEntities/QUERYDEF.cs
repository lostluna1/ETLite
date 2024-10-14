using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QUERYDEF {

		public uint? DATASOURCENAMEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string NAME { get; set; }

		public uint? QUERYCATEGORYID { get; set; }

		public uint? QUERYDEFID { get; set; }

		public uint? QUERYTYPEID { get; set; }

		public string WORKSPACECODE { get; set; }

	}

}
