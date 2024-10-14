using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_COMPUTER {

		public string COMPUTERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEHISTORYID { get; set; }

		public string COMPUTERNAME { get; set; }

		public string DEFAULTPAGEID { get; set; }

		public string DESCRIPTION { get; set; }

		public string FILTERTAGS { get; set; }

		public uint? ICONID { get; set; }

		public string IPADDRESS { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string OPERATIONID { get; set; }

		public string RESOURCEID { get; set; }

		public string SETUPACCESSID { get; set; }

		public string WORKCENTERID { get; set; }

		public string WORKSTATIONID { get; set; }

	}

}
