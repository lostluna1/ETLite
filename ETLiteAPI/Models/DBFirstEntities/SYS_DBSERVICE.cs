using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_DBSERVICE {

		public string DBSERVICEID { get; set; }

		public string ADDRESS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DATABASENAME { get; set; }

		public string DBIPADDRESS { get; set; }

		public string DBSERVICENAME { get; set; }

		public int? ENABLE { get; set; }

		public string GROUPID { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string PHONENO { get; set; }

		public string PWD { get; set; }

		public string REMARK { get; set; }

		public string USERID { get; set; }

	}

}
