using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_POWERONINSPECTION {

		public string BIZ_POWERONINSPECTIONID { get; set; }

		public uint? ACTIVE { get; set; }

		public string BIZ_POWERONINSPECTIONNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? EXECUTIONTIME { get; set; }

		public string EXECUTORID { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISBYCONTAINERQTY { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGORDERID { get; set; }

		public string MODIFIEDEMPLOYEEID { get; set; }

		public DateTime? MODIFIEDTIME { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESSID { get; set; }

		public string TASKSTATUS { get; set; }

	}

}
