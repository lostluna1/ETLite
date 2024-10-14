using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SECURITYAUDITTRAIL {

		public string SECURITYAUDITTRAILID { get; set; }

		public string AUDITTRAILINFO { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string SECURITYAUDITTRAILHEADERID { get; set; }

		public string SECURITYUSERNAME { get; set; }

		public string TXNID { get; set; }

	}

}
