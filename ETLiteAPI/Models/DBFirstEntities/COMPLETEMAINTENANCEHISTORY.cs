using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class COMPLETEMAINTENANCEHISTORY {

		public string COMPLETEMAINTENANCEHISTORYID { get; set; }

		public uint? BIZ_ACTUALWORKINGHOUR { get; set; }

		public string BIZ_EQUIPMAINTTASK { get; set; }

		public string BIZ_INSPECTATTACH { get; set; }

		public string BIZ_INSPECTORID { get; set; }

		public string BIZ_INSPECTREMARK { get; set; }

		public DateTime? BIZ_TASKCLOSETIME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public uint? FORCEMAINTENANCE { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? RESETALL { get; set; }

		public string TXNID { get; set; }

	}

}
