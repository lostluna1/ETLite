﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SECURITYMASKDEFINITION {

		public uint SECURITYMASKID { get; set; }

		public string DESCRIPTION { get; set; }

		public string NAME { get; set; }

	}

}
