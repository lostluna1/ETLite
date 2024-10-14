using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_EQUIPDAILYINSPECTTASK {

		public string BIZ_EQUIPDAILYINSPECTTASKID { get; set; }

		public string BIZ_EQUIPDAILYINSPECTTASKNAME { get; set; }

		public string BIZ_INSPECTATTACH { get; set; }

		public string BIZ_INSPECTORID { get; set; }

		public string BIZ_INSPECTREMARK { get; set; }

		public string BIZ_INSPECTTYPE { get; set; }

		public string BIZ_JUDGEMENTRESULT { get; set; }

		public string BIZ_RESOURCEID { get; set; }

		public string BIZ_SHIFTID { get; set; }

		public DateTime? BIZ_TASKCLOSETIME { get; set; }

		public DateTime? BIZ_TASKSTARTTIME { get; set; }

		public string BIZ_TASKSTATUSID { get; set; }

		public string BIZ_TOOLID { get; set; }

		public string BIZ_WOID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
