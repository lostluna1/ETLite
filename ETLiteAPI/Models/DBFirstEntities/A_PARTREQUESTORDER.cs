using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_PARTREQUESTORDER {

		public string PARTREQUESTORDERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISDONE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string JOBID { get; set; }

		public string LASTINTEGRATIONTXNID { get; set; }

		public string NOTES { get; set; }

		public string PARTREQUESTORDERNAME { get; set; }

		public string REQUESTSTATUS { get; set; }

		public uint? REQUESTTYPE { get; set; }

		public uint? REQUIREACKNOWLEDGEEMAIL { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

	}

}
