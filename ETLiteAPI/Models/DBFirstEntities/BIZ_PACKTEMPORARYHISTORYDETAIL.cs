﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PACKTEMPORARYHISTORYDETAIL {

		public string BIZ_PACKTEMPORARYID { get; set; }

		public uint FIELDID { get; set; }

		public uint SEQUENCE { get; set; }

		public string HISTORYDETAILSID { get; set; }

	}

}
