using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SCHEDULEDBUSINESSRULE {

		public string SCHEDULEDBUSINESSRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public uint? DAYOFMONTH { get; set; }

		public uint? DAYOFWEEK { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? DUETIME { get; set; }

		public DateTime? DUETIMEGMT { get; set; }

		public DateTime? ENDDATE { get; set; }

		public DateTime? ENDDATEGMT { get; set; }

		public string EXECUTIONCONTEXT { get; set; }

		public uint? EXECUTIONCONTEXTTYPE { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISADVANCEDMODE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISLASTDAYOFMONTH { get; set; }

		public uint? ISSYSTEMDEFINED { get; set; }

		public string LOCKGUID { get; set; }

		public uint? MONTHOFYEAR { get; set; }

		public string NOTES { get; set; }

		public string ONEXECUTE { get; set; }

		public uint? RECURRENCECOUNT { get; set; }

		public uint? RECURRENCEFREQUENCY { get; set; }

		public uint? RECURRENCEPATTERN { get; set; }

		public string SCHEDULEDAYSOFMONTH { get; set; }

		public string SCHEDULEDAYSOFWEEK { get; set; }

		public string SCHEDULEDBUSINESSRULENAME { get; set; }

		public string SCHEDULEHOURS { get; set; }

		public string SCHEDULEMONTHS { get; set; }

		public string SETUPACCESSID { get; set; }

		public DateTime? STARTDATE { get; set; }

		public DateTime? STARTDATEGMT { get; set; }

		public uint? STATUS { get; set; }

	}

}
