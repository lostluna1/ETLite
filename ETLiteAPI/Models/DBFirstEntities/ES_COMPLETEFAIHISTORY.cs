using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_COMPLETEFAIHISTORY {

		public string ES_COMPLETEFAIHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public DateTime? COMPLETEFAIDATETIME { get; set; }

		public uint? COMPONENTINSPECTED { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ES_COMPLETEFAIHISTORYNAME { get; set; }

		public uint? ES_FAITRACKINGMODE { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public string SPECID { get; set; }

		public DateTime? STARTFAIDATETIME { get; set; }

		public string TXNID { get; set; }

	}

}
