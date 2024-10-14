using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CSIVIEW_NONCONFORMANCE {

		public string BRIEFDESCRIPTION { get; set; }

		public uint? CATEGORY { get; set; }

		public string CATEGORYNAME { get; set; }

		public string CLASSIFICATION { get; set; }

		public DateTime? CLOSEDATE { get; set; }

		public string CLOSEDBY { get; set; }

		public string CLOSEDESCRIPTION { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISCOVERYAREA { get; set; }

		public string FAILUREMODENAME { get; set; }

		public string INITIATOR { get; set; }

		public string INITIATORORGANIZATION { get; set; }

		public string INSTANCEID { get; set; }

		public string LOT { get; set; }

		public string MAINTENANCEREQNAME { get; set; }

		public string NAME { get; set; }

		public DateTime? OCCURRENCEDATE { get; set; }

		public string OPERATIONNAME { get; set; }

		public string ORGANIZATION { get; set; }

		public string OWNER { get; set; }

		public string PRIORITYLEVEL { get; set; }

		public string PRODUCT { get; set; }

		public string PRODUCTREV { get; set; }

		public decimal? QTY { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public string REPORTER { get; set; }

		public string REPORTERORGANIZATION { get; set; }

		public string RESOLUTIONCODE { get; set; }

		public string RESOURCENAME { get; set; }

		public string ROLE { get; set; }

		public uint? STATUS { get; set; }

		public string STATUSNAME { get; set; }

		public string SUBCLASSIFICATION { get; set; }

	}

}
