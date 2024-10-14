using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RESOLVEDPERMISSIONS_TEMP {

		public string OBJECTINSTANCEID { get; set; }

		public decimal? OBJECTMETAID { get; set; }

		public string ORGANIZATIONNAME { get; set; }

		public decimal? PERMISSIONMODE { get; set; }

		public string PERMISSIONNAME { get; set; }

		public decimal? PERMISSIONTYPE { get; set; }

		public string ROLENAME { get; set; }

	}

}
