using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_CRITICAL_SPEC_DASHBOARD_WIP {

		public DateTime? CREATION_DATE { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? LAST_PASS_QTY { get; set; }

		public decimal? LAST_SEQ { get; set; }

		public string MFGORDERNAME { get; set; }

		public decimal? PASS_QTY { get; set; }

		public string PRODUCTNAME { get; set; }

		public uint? SEQUENCE { get; set; }

		public string SPEC_DESCRIPTION { get; set; }

		public string SPECNAME { get; set; }

		public decimal? WIP_QTY { get; set; }

		public decimal? WO_QTY { get; set; }

	}

}
