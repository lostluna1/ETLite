using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_FAIINSPECTIONTASKCHILD {

		public string BIZ_FAIINSPECTIONTASKCHILDID { get; set; }

		public string BIZ_FAIINSPECTIONTASKCHILDNAME { get; set; }

		public uint? BIZ_ISUPLOADSPC { get; set; }

		public string BIZ_SAMPLEDATAPOINTTYPEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? FINALJUDGMENT { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string LOWERLIMIT { get; set; }

		public string LOWERLIMIT1 { get; set; }

		public string NOTES { get; set; }

		public uint? QCCONFRIM { get; set; }

		public string RESULTS { get; set; }

		public string SAMPLEDATAPOINT { get; set; }

		public decimal? SAMPLEQTY { get; set; }

		public string SAMPLETEST { get; set; }

		public uint? SAMPLETYPE { get; set; }

		public string SAMPLINGPLAN { get; set; }

		public string SEQ { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SN { get; set; }

		public uint? STATUS { get; set; }

		public string TASKNO { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string UPPERLIMIT { get; set; }

		public string UPPERLIMIT1 { get; set; }

	}

}
