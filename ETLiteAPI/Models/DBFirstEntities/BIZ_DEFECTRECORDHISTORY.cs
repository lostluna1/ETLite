using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_DEFECTRECORDHISTORY {

		public string BIZ_DEFECTRECORDHISTORYID { get; set; }

		public string BIZ_DEFECTRECORDHISTORYNAME { get; set; }

		public string BIZ_NGCONTAINER { get; set; }

		public string BIZ_RFID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERID { get; set; }

		public string CONTAINERNAME { get; set; }

		public DateTime? CREATETIME { get; set; }

		public string CUSTOMERCONTAINER { get; set; }

		public string DEFECTREASONNAME { get; set; }

		public string EMPLOYEEID { get; set; }

		public string HISTORYID { get; set; }

		public string HISTORYMAINLINEID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISCONTAINERRENAME { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public uint? ISPASS { get; set; }

		public string MFGORDERID { get; set; }

		public string SPECID { get; set; }

		public string TXNID { get; set; }

	}

}
