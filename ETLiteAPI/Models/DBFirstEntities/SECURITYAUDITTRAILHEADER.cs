using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SECURITYAUDITTRAILHEADER {

		public string SECURITYAUDITTRAILHEADERID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string COPYFROMSERVICENAME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string EXECUTEACTION { get; set; }

		public uint? EXECUTEACTIONID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public uint? OBJECTTYPEID { get; set; }

		public string OBJECTTYPENAME { get; set; }

		public DateTime? SYSTEMDATE { get; set; }

		public DateTime? SYSTEMDATEGMT { get; set; }

		public DateTime? TXNDATE { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNID { get; set; }

		public string TXNNAME { get; set; }

		public string USERID { get; set; }

		public string USERNAME { get; set; }

	}

}
