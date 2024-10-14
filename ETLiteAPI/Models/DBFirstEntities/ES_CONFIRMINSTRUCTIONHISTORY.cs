using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_CONFIRMINSTRUCTIONHISTORY {

		public string ES_CONFIRMINSTRUCTIONHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string EMPLOYEEID { get; set; }

		public string ES_CONFIRMINSTRUCTIONHISTONAME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INSTRUCTIONID { get; set; }

		public string INSTRUCTIONTEXT { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MFGORDERID { get; set; }

		public string PRODUCTID { get; set; }

		public string TXNID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
