using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DBDATASOURCENAMES {

		public uint DATASOURCENAMEID { get; set; }

		public string CONNECTIONPARAMETERS { get; set; }

		public string DATABASEHOSTNAME { get; set; }

		public string DATABASENAME { get; set; }

		public string DATABASETYPE { get; set; }

		public string DATASOURCENAME { get; set; }

		public uint? DBDATASOURCEUSAGEID { get; set; }

		public string DESCRIPTION { get; set; }

		public bool? ENCRYPTION { get; set; }

		public string PASSWORD { get; set; }

		public string SCHEMANAME { get; set; }

		public string USERID { get; set; }

	}

}
