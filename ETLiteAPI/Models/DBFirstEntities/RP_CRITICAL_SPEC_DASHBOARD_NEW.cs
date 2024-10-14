using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_CRITICAL_SPEC_DASHBOARD_NEW {

		public decimal? ACHIEVEMENT { get; set; }

		public decimal? ACTUAL_QTY { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public string ENDTIME { get; set; }

		public string FACTORYNAME { get; set; }

		public string FACTOTY_NOTES { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PRODUCTNAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPEC_DESCRIPTION { get; set; }

		public string SPECNAME { get; set; }

		public string STARTTIME { get; set; }

		public decimal? TARGETQTY { get; set; }

		public string TXNDATE { get; set; }

	}

}
