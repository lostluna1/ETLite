using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYS_WORKFLOWTABLEAUDITLOG {

		public string ID { get; set; }

		public DateTime? AUDITDATE { get; set; }

		public int? AUDITID { get; set; }

		public string AUDITOR { get; set; }

		public string AUDITRESULT { get; set; }

		public int? AUDITSTATUS { get; set; }

		public DateTime? CREATEDATE { get; set; }

		public string REMARK { get; set; }

		public string STEPID { get; set; }

		public string STEPNAME { get; set; }

		public string WORKFLOWTABLE_ID { get; set; }

		public string WORKFLOWTABLESTEP_ID { get; set; }

	}

}
