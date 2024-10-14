using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CALENDARSHIFT {

		public string CALENDARSHIFTID { get; set; }

		public DateTime? CALENDARDATE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FISCALMONTH { get; set; }

		public uint? FISCALQUARTER { get; set; }

		public uint? FISCALWEEK { get; set; }

		public uint? FISCALYEAR { get; set; }

		public uint? ISFROZEN { get; set; }

		public decimal? ISNONSCHEDULEDTIME { get; set; }

		public string MFGCALENDARID { get; set; }

		public DateTime? SHIFTEND { get; set; }

		public string SHIFTID { get; set; }

		public DateTime? SHIFTSTART { get; set; }

		public string TEAMID { get; set; }

	}

}
