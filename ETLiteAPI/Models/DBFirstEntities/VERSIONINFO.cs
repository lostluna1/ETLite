using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class VERSIONINFO {

		public uint VERSION { get; set; }

		public string BACKUPDATASOURCE { get; set; }

		public string BACKUPDIRECTORY { get; set; }

		public string PASSWORD { get; set; }

		public string SCHEMANAME { get; set; }

		public string USERID { get; set; }

	}

}
