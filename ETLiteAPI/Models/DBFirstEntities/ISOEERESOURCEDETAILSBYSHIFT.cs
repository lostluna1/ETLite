using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISOEERESOURCEDETAILSBYSHIFT {

		public DateTime? CALENDARDATE { get; set; }

		public string CALENDARSHIFTID { get; set; }

		public uint? OEELOSSCATEGORY { get; set; }

		public string OEELOSSCATEGORYNAME { get; set; }

		public string RESOURCEFAMILY { get; set; }

		public string RESOURCEID { get; set; }

		public string RESOURCENAME { get; set; }

		public uint? RESOURCESTATE { get; set; }

		public string RESOURCESTATENAME { get; set; }

		public string RESOURCESTATUSCODE { get; set; }

		public string RESOURCESTATUSREASON { get; set; }

		public string SHIFT { get; set; }

		public decimal? TIMEINSTATUS { get; set; }

	}

}
