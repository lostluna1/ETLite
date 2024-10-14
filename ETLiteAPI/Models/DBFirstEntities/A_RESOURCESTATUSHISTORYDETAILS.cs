using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class A_RESOURCESTATUSHISTORYDETAILS {

		public string RESOURCESTATUSHISTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? EMPLOYEEACTION { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? PARAMACTION { get; set; }

		public string PARAMID { get; set; }

		public string PARAMOLDVALUE { get; set; }

		public string PARAMTYPE { get; set; }

		public string PARAMVALUE { get; set; }

		public string RESOURCESTATUSHISTORYID { get; set; }

		public uint? TOOLACTION { get; set; }

		public string TOOLID { get; set; }

		public uint? TXNACTION { get; set; }

		public string TXNID { get; set; }

	}

}
