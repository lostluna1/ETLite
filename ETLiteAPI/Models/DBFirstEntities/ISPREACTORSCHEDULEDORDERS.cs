using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISPREACTORSCHEDULEDORDERS {

		public string ISPREACTORSCHEDULEDORDERSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public decimal? CONTAINERSPROCESSEDQTY { get; set; }

		public decimal? DURATION { get; set; }

		public string ERPOPERATIONNAME { get; set; }

		public decimal? ERPOPERATIONNO { get; set; }

		public string ES_MFGLINEID { get; set; }

		public string ES_SMTGROUPING { get; set; }

		public uint? ES_STARTVIRTUALSN { get; set; }

		public DateTime? FINISHEDDATE { get; set; }

		public DateTime? FINISHEDDATEGMT { get; set; }

		public uint? ISCHECKEDCONTAINER { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISPREACTORSCHEDULEDORDERSNAME { get; set; }

		public string ISPREACTORSCHEDULEID { get; set; }

		public string ISRESOLVEDCONTAINERID { get; set; }

		public string LINEASSIGNMENTID { get; set; }

		public string MFGORDERID { get; set; }

		public decimal? MFGORDERQTY { get; set; }

		public string OPERATIONID { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public decimal? PRIORITY { get; set; }

		public string PRODUCTID { get; set; }

		public string RESOURCEGROUPID { get; set; }

		public string RESOURCEID { get; set; }

		public string SCHEDULINGOPERATIONNAME { get; set; }

		public decimal? SCHEDULINGOPERATIONNO { get; set; }

		public uint? SEQUENCE { get; set; }

		public decimal? SETUPTIME { get; set; }

		public string SPECID { get; set; }

		public string STATUSID { get; set; }

		public decimal? TIMEPERBATCH { get; set; }

		public uint? UNITSPERHOUR { get; set; }

		public decimal? UNSCHEDULEDTIME { get; set; }

	}

}
