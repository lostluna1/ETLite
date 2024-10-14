using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_EMPLOYEEJOBRECORDS {

		public string BIZ_EMPLOYEEJOBRECORDSID { get; set; }

		public string BIZ_EMPLOYEEJOBRECORDSNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public DateTime? CREATIONTIME { get; set; }

		public string DESCRIPTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public DateTime? ENDTIMEONTHEJOB { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string MFGLINEID { get; set; }

		public string NOTES { get; set; }

		public uint? ONTHEJOBSTATE { get; set; }

		public string SETUPACCESSID { get; set; }

		public string SHIFTID { get; set; }

		public string SPECID { get; set; }

		public DateTime? STARTTIMEONTHEJOB { get; set; }

	}

}
