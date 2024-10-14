using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PACKTEMPORARYHISTORY {

		public string BIZ_PACKTEMPORARYHISTORYID { get; set; }

		public string BIZ_PACKTEMPORARYHISTORYNAME { get; set; }

		public string BOXCONTAINERID { get; set; }

		public string BOXCONTAINERNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public DateTime? CREATIONDATE { get; set; }

		public string EMPLOYEEID { get; set; }

		public string EMPLOYEENAME { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MFGLINEID { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERID { get; set; }

		public string MFGORDERNAME { get; set; }

		public DateTime? PACKTEMPORARYTIME { get; set; }

		public uint? STATUS { get; set; }

		public string TXNID { get; set; }

	}

}
