using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_IPQCINSPECTIONTASK {

		public string BIZ_IPQCINSPECTIONTASKID { get; set; }

		public string ATTACHMENT { get; set; }

		public string BIZ_IPQCINSPECTIONTASKNAME { get; set; }

		public string BIZ_IPQCSHIFTID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? INSPECTQTY { get; set; }

		public uint? ISCOMPLATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISUPLOADSPC { get; set; }

		public string MFGORDERID { get; set; }

		public string NOTES { get; set; }

		public uint? QCCONFRIM { get; set; }

		public string QCEMPLOYEEID { get; set; }

		public DateTime? QCTXNDATE { get; set; }

		public string REMARK { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SPECID { get; set; }

		public uint? TASKSTATUS { get; set; }

		public DateTime? TXNDATE { get; set; }

	}

}
