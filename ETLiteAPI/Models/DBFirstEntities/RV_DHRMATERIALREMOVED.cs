using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRMATERIALREMOVED {

		public string CONTAINERNAME { get; set; }

		public string COSIGNERFULLNAME { get; set; }

		public string DESTINATIONLOT { get; set; }

		public string DHR_CONTAINERNAME { get; set; }

		public string EMPLOYEENAME { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string ESIGMEANINGNAME { get; set; }

		public string PARENTCONTAINERNAME { get; set; }

		public string PARENTPRIMARYSERIALNUMBER { get; set; }

		public string PARENTSERIALNUMBER2 { get; set; }

		public string PARENTSERIALNUMBER3 { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REMOVALCONTAINER { get; set; }

		public string REMOVALREASONNAME { get; set; }

		public string REMOVEDETAILS { get; set; }

		public string SIGNERFULLNAME { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string UOMNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
