using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class KANBANQUALITYEFFICIENCYTEMP {

		[JsonProperty, Column(Name = "BIZ_BUNAME", StringLength = 50)]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", StringLength = 50)]
		public string BIZCUSTOMERPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", StringLength = 50)]
		public string BIZEQTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANTIME", StringLength = 50)]
		public string BIZMANTIME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string BREAKTIME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string COMPLETEQTY { get; set; }

		[JsonProperty, Column(Name = "CUSTOMER_DESCRIPTION", StringLength = 50)]
		public string CUSTOMERDESCRIPTION { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string CUSTOMERNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ENDTIME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ETUOMNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string FQCNGQTY { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string FQCPASSQTY { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MANPOWER { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string MTUOMNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ORDERSTATUSNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string ORDERTYPENAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PDESCRIPTION { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PRODUCTNAME1 { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PRODUCTNAME2 { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PRODUCTTYPENAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string PTDESCRIPTION { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string SHIFTCOMPLATEQTY { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string STARTTIME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string SYSDATETIME { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string WOCOMPLETEDATE { get; set; }

		[JsonProperty, Column(StringLength = 50)]
		public string WOQTY { get; set; }

	}

}
