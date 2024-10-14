using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_DEPARTMENT {

		public string DEPARTMENTID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public int? CREATEID { get; set; }

		public string CREATOR { get; set; }

		public string DBSERVICEID { get; set; }

		public string DEPARTMENTCODE { get; set; }

		public string DEPARTMENTNAME { get; set; }

		public string DEPARTMENTTYPE { get; set; }

		public int? ENABLE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? MODIFYID { get; set; }

		public string PARENTID { get; set; }

		public string REMARK { get; set; }

	}

}
