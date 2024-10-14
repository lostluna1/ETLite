using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_EQPT_INSPECTION {

		public string BIZ_ASSETDEPT { get; set; }

		public string BIZ_ASSETDES { get; set; }

		public string BIZ_EQUIPDAILYINSPECTTASKNAME { get; set; }

		public string BIZ_INSPECTTYPE { get; set; }

		public string BIZ_JUDGEMENTRESULT { get; set; }

		public string BIZ_SAPASSETCODE { get; set; }

		public DateTime? BIZ_TASKCLOSETIME { get; set; }

		public string BIZ_TASKSTATUSNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string FACTORYNAME { get; set; }

		public string OBJECTTYPE { get; set; }

		public string RESOURCE_DESCRIPTION { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCENAME { get; set; }

	}

}
