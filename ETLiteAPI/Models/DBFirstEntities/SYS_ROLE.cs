using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_ROLE {

		public int ROLE_ID { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public string CREATOR { get; set; }

		public string DATAUTH { get; set; }

		public string DBSERVICEID { get; set; }

		public string DELETEBY { get; set; }

		public int? DEPT_ID { get; set; }

		public string DEPTNAME { get; set; }

		public sbyte? ENABLE { get; set; }

		public string MODIFIER { get; set; }

		public DateTime? MODIFYDATE { get; set; }

		public int? ORDERNO { get; set; }

		public int PARENTID { get; set; }

		public string ROLENAME { get; set; }

	}

}
