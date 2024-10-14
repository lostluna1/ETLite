using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DATAPOINTHISTORY {

		public string DATAPOINTHISTORYID { get; set; }

		public string BIZ_EQUIPBORROWTASKID { get; set; }

		public string BIZ_EQUIPDAILYINSPECTTASKID { get; set; }

		public string BIZ_EQUIPMAINTTASK { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DATACOLLECTIONDEFID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string TXNID { get; set; }

	}

}
