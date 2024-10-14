using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EQPT_MAINTENANCE {

		public string BIZ_ASSETDEPT { get; set; }

		public string BIZ_ASSETDES { get; set; }

		public string BIZ_EQUIPMAINTTASK { get; set; }

		public string PHYSICALLOCATIONNAME { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
