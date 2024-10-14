using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISPREACTORSCHEDULEDCNTR {

		public string ISPREACTORSCHEDULEDCNTRID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERNAME { get; set; }

		public decimal? CONTAINERQTY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISPREACTORSCHEDULEDCNTRNAME { get; set; }

		public string ISPREACTORSCHEDULEEXID { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public decimal? PRIORITY { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string SPECNAME { get; set; }

		public uint? SPECSEQUENCE { get; set; }

	}

}
