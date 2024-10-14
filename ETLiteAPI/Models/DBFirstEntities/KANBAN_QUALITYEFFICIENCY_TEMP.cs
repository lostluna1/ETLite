using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class KANBAN_QUALITYEFFICIENCY_TEMP {

		public string BIZ_BUNAME { get; set; }

		public string BIZ_CUSTOMERPRODUCT { get; set; }

		public string BIZ_EQTTIME { get; set; }

		public string BIZ_MANTIME { get; set; }

		public string BREAKTIME { get; set; }

		public string COMPLETEQTY { get; set; }

		public string CUSTOMER_DESCRIPTION { get; set; }

		public string CUSTOMERNAME { get; set; }

		public string DESCRIPTION { get; set; }

		public string ENDTIME { get; set; }

		public string ETUOMNAME { get; set; }

		public string FACTORYNAME { get; set; }

		public string FQCNGQTY { get; set; }

		public string FQCPASSQTY { get; set; }

		public string MANPOWER { get; set; }

		public string MFGLINENAME { get; set; }

		public string MFGORDERNAME { get; set; }

		public string MTUOMNAME { get; set; }

		public string ORDERSTATUSNAME { get; set; }

		public string ORDERTYPENAME { get; set; }

		public string PDESCRIPTION { get; set; }

		public string PLANNEDCOMPLETIONDATE { get; set; }

		public string PLANNEDSTARTDATE { get; set; }

		public string PRODUCTNAME1 { get; set; }

		public string PRODUCTNAME2 { get; set; }

		public string PRODUCTTYPENAME { get; set; }

		public string PTDESCRIPTION { get; set; }

		public string SHIFTCOMPLATEQTY { get; set; }

		public string SHIFTNAME { get; set; }

		public string STARTTIME { get; set; }

		public string SYSDATETIME { get; set; }

		public string WOCOMPLETEDATE { get; set; }

		public string WOQTY { get; set; }

	}

}
