﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_LABLECHECKGROUPBIZ_ITEMCHE {

		public string BIZ_LABLECHECKGROUPID { get; set; }

		public uint FIELDID { get; set; }

		public uint SEQUENCE { get; set; }

		public string BIZ_ITEMCHECKLLISTID { get; set; }

	}

}
