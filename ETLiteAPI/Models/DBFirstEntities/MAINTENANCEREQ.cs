using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MAINTENANCEREQ {

		public string MAINTENANCEREQID { get; set; }

		public DateTime? BIZ_SCHEDULECOMPLETIONDATE { get; set; }

		public uint? BIZ_SCHEDULEWORKINGHOUR { get; set; }

		public string BOMBASEID { get; set; }

		public string BOMID { get; set; }

		public DateTime? CALCULATEDENDDATE { get; set; }

		public DateTime? CALCULATEDENDDATEGMT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DATACOLLECTIONDEFBASEID { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public uint? DAYOFMONTH { get; set; }

		public uint? DAYOFWEEK { get; set; }

		public string DESCRIPTION { get; set; }

		public string DOCUMENTSETID { get; set; }

		public string DUEEMAILTEXT { get; set; }

		public string ECO { get; set; }

		public DateTime? ENDDATE { get; set; }

		public DateTime? ENDDATEGMT { get; set; }

		public uint? ENFORCECHECKLISTSEQUENCE { get; set; }

		public string ESIGREQUIREMENTID { get; set; }

		public decimal? ESTIMATEDDURATION { get; set; }

		public string FILTERTAGS { get; set; }

		public DateTime? FIRSTMAINTDATEDUE { get; set; }

		public DateTime? FIRSTMAINTDATEDUEGMT { get; set; }

		public uint? FREQUENCY { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBMODELID { get; set; }

		public string MAINTENANCEREASONID { get; set; }

		public string MAINTENANCEREQBASEID { get; set; }

		public uint? MONTHOFYEAR { get; set; }

		public string NOTES { get; set; }

		public uint? OCCURRENCES { get; set; }

		public string PASTDUEEMAILTEXT { get; set; }

		public string PENDINGEMAILTEXT { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public uint? RECURRINGDATEPATTERN { get; set; }

		public uint? RECURRINGDATETYPE { get; set; }

		public string REVISION { get; set; }

		public DateTime? SCHEDULEDATE { get; set; }

		public DateTime? SCHEDULEDATEGMT { get; set; }

		public DateTime? SEEDDATE { get; set; }

		public DateTime? SEEDDATEGMT { get; set; }

		public string SETUPACCESSID { get; set; }

		public uint? STATUS { get; set; }

		public decimal? TOLERANCEPERIOD { get; set; }

		public decimal? TOLERANCEQTY { get; set; }

		public decimal? TOLERANCEQTY2 { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public decimal? WARNINGPERIOD { get; set; }

		public decimal? WARNINGQTY { get; set; }

		public decimal? WARNINGQTY2 { get; set; }

		public string WIPMSGDEFMGRID { get; set; }

	}

}
