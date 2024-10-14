using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELETE_RP_DASHBOARD_DATA {

		public decimal? ADDQTY { get; set; }

		public string BIZ_BUNAME { get; set; }

		public decimal? BIZ_EQTTIME { get; set; }

		public decimal? BIZ_MANTIME { get; set; }

		public string BREAKTIME { get; set; }

		public decimal? COMPLETEQTY { get; set; }

		public string CUSTOMER_DESCRIPTION { get; set; }

		public string CUSTOMERNAME { get; set; }

		public string ENDTIME { get; set; }

		public string FACTORYNAME { get; set; }

		public decimal? FQCNGQTY { get; set; }

		public decimal? FQCPASSQTY { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string ORDERTYPENAME { get; set; }

		public decimal? PLANQTY { get; set; }

		public string PRODUCTNAME1 { get; set; }

		public string PRODUCTNAME2 { get; set; }

		public decimal? SHIFTCOMPLATEQTY { get; set; }

		public string SHIFTNAME { get; set; }

		public string STARTTIME { get; set; }

		public decimal? WOQTY { get; set; }

	}

}
