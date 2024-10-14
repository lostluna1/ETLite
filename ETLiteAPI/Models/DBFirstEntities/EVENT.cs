using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENT {

		public string EVENTID { get; set; }

		public string ATTACHMENTSID { get; set; }

		public string BRIEFDESCRIPTION { get; set; }

		public uint? CATEGORY { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHECKLISTID { get; set; }

		public uint? CHECKLISTSAVED { get; set; }

		public string CLASSIFICATIONID { get; set; }

		public DateTime? CLOSEDATE { get; set; }

		public DateTime? CLOSEDATEGMT { get; set; }

		public string CLOSEDBYID { get; set; }

		public string CLOSEDESCRIPTION { get; set; }

		public string DESCRIPTION { get; set; }

		public string DISCOVERYAREA { get; set; }

		public uint? ESCALATETOCOMPLAINT { get; set; }

		public string EVENTDATAID { get; set; }

		public string EVENTNAME { get; set; }

		public string INITIATORID { get; set; }

		public string INITIATORORGANIZATIONID { get; set; }

		public uint? ISCARREQUIREDTOCLOSE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISSUBMITTED { get; set; }

		public DateTime? OCCURRENCEDATE { get; set; }

		public DateTime? OCCURRENCEDATEGMT { get; set; }

		public string ORGANIZATIONID { get; set; }

		public string ORIGPROCESSMODELTEMPLATEID { get; set; }

		public string OWNERID { get; set; }

		public string PRIORITYLEVELID { get; set; }

		public string PROCESSMODELID { get; set; }

		public string QUALITYRESOLUTIONCODEID { get; set; }

		public DateTime? REPORTEDDATE { get; set; }

		public DateTime? REPORTEDDATEGMT { get; set; }

		public string REPORTERID { get; set; }

		public string REPORTERORGANIZATIONID { get; set; }

		public string RISKASSESSMENTID { get; set; }

		public string ROLEID { get; set; }

		public uint? STATUS { get; set; }

		public string SUBCLASSIFICATIONID { get; set; }

		public uint? TRIAGECOMPLETE { get; set; }

	}

}
