﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_MOPCBASNCREATHISHISTORYDET {

		public string BIZ_MOPCBASNCREATHISID { get; set; }

		public uint FIELDID { get; set; }

		public uint SEQUENCE { get; set; }

		public string HISTORYDETAILSID { get; set; }

	}

}
