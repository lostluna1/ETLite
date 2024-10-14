using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISPREACTORSCHEDULE {

		public string ISPREACTORSCHEDULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FACTORYID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISPREACTORSCHEDULENAME { get; set; }

		public string ISWORKFLOWID { get; set; }

		public string NOTES { get; set; }

		public uint? RECORDCOUNT { get; set; }

		public uint? SCHEDULESTATUS { get; set; }

		public string SETUPACCESS { get; set; }

	}

}
