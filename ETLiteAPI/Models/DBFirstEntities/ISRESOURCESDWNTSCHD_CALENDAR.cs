using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISRESOURCESDWNTSCHD_CALENDAR {

		public DateTime? CALENDARDATE { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public string FACTORYNAME { get; set; }

		public DateTime? ISENDTIME { get; set; }

		public DateTime? ISSTARTTIME { get; set; }

		public string MFGCALENDARNAME { get; set; }

		public string RESOURCEFAMILYNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public DateTime? SHIFTEND { get; set; }

		public string SHIFTID { get; set; }

		public DateTime? SHIFTSTART { get; set; }

	}

}
