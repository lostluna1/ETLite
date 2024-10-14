using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class TODOLISTENTRIES {

		public string ACTIVITYPLAN { get; set; }

		public string APPROVALENTRYROLE { get; set; }

		public string APPROVALSHEETPARENT { get; set; }

		public decimal? APPROVALSTATUS { get; set; }

		public decimal? APPROVALSUBSTITUTEOPTION { get; set; }

		public uint? CATEGORY { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public decimal? DATACOLLECTIONDEFINED { get; set; }

		public DateTime? DESIGNATEDDATE { get; set; }

		public DateTime? DESIGNATEDDATEGMT { get; set; }

		public DateTime? DUEDATE { get; set; }

		public DateTime? DUEDATEGMT { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? IDENTIFIERCDOTYPE { get; set; }

		public decimal? IDENTIFIERTYPE { get; set; }

		public decimal? NOTIFICATIONTYPE { get; set; }

		public string ORGANIZATION { get; set; }

		public string OWNER { get; set; }

		public string PRIORITYLEVEL { get; set; }

		public string PROCESSMODEL { get; set; }

		public decimal? PROCESSSTAGE { get; set; }

		public string QUALITYOBJECT { get; set; }

		public decimal? QUALITYSTATUS { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string ROLE { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public string TODOLISTITEMTYPE { get; set; }

		public decimal? TRIAGECOMPLETE { get; set; }

	}

}
