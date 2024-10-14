using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class MODELINGAUDITTRAIL {

		public string MODELINGAUDITTRAILID { get; set; }

		public string AUDITTRAILINFO { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MODELINGAUDITTRAILHEADERID { get; set; }

		public string OBJECTDISPLAYNAME { get; set; }

		public string OBJECTINSTANCEID { get; set; }

		public uint? OBJECTTYPEID { get; set; }

		public string OBJECTTYPENAME { get; set; }

		public string TXNID { get; set; }

	}

}
