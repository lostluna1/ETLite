using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class CIOSYSTEMDISPATCHRULE {

		public string CIOSYSTEMDISPATCHRULEID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string CIOSYSTEMDISPATCHRULENAME { get; set; }

		public string CIOWORKFLOWBASEID { get; set; }

		public string CIOWORKFLOWID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? DISPATCHINTERVAL { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string SETUPACCESS { get; set; }

		public string WORKFLOWADDRESS { get; set; }

	}

}
