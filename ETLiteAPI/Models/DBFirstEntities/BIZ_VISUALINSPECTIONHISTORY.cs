using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_VISUALINSPECTIONHISTORY {

		public string BIZ_VISUALINSPECTIONHISTORYID { get; set; }

		public string BIZ_VISUALINSPECTIONHISTORNAME { get; set; }

		public string BU { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string EMPLOYEE { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LINE { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string RESOURCEID { get; set; }

		public string RFIDEMPNO { get; set; }

		public string RFIDNUMBER { get; set; }

		public DateTime? RFIDOPERATETIME { get; set; }

		public string RFIDORDER { get; set; }

		public string RFIDSPEC { get; set; }

		public string SHIFT { get; set; }

		public string SPECID { get; set; }

		public string SPECNAME { get; set; }

		public string TXNID { get; set; }

		public string WOID { get; set; }

	}

}
