using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class UPDATECHANGEPKGHISTORY {

		public string UPDATECHANGEPKGHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHANGEPACKAGENAME { get; set; }

		public string ECOECN { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public uint? LOCKLNSTANCES { get; set; }

		public uint? NOTIFYOWNERALLSTATECHANGES { get; set; }

		public uint? NOTIFYOWNERROLEALLSTATECHGS { get; set; }

		public string OWNERID { get; set; }

		public string OWNERROLEID { get; set; }

		public string PACKAGETYPEID { get; set; }

		public string PARENTID { get; set; }

		public string PRIORITYID { get; set; }

		public string REASONID { get; set; }

		public DateTime? RECOMMENDEDDEPLOYMENTDATE { get; set; }

		public string TXNID { get; set; }

	}

}
