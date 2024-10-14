using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_FAIINSPECTIONTASK {

		public string BIZ_FAIINSPECTIONTASKID { get; set; }

		public string ATTACHMENT { get; set; }

		public string BIZ_CHECKREASONID { get; set; }

		public string BIZ_FAIINSPECTIONTASKNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? INSPECTIONQTY { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISPASS { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public uint? QCCONFRIM { get; set; }

		public string QCEMPLOYEEID { get; set; }

		public DateTime? QCTXNDATE { get; set; }

		public string REMARK { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SHIFTID { get; set; }

		public uint? TASKSTATUS { get; set; }

		public DateTime? TXNDATE { get; set; }

	}

}
