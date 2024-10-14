﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EMPLOYEEROLE {

		public string EMPLOYEEROLEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ORGANIZATIONID { get; set; }

		public uint? PROPAGATETOCHILDORGS { get; set; }

		public string ROLEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
