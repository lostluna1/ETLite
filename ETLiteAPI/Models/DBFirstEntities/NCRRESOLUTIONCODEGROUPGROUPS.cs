﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class NCRRESOLUTIONCODEGROUPGROUPS {

		public uint FIELDID { get; set; }

		public string NCRRESOLUTIONCODEGROUPID { get; set; }

		public uint SEQUENCE { get; set; }

		public string GROUPSID { get; set; }

	}

}
