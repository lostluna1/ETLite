using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RV_DHRMATERIALISSUED {

		public string BINSIZE { get; set; }

		public string COSIGNERFULLNAME { get; set; }

		public string DATECODE { get; set; }

		public string DESCRIPTION { get; set; }

		public string DHR_CONTAINERNAME { get; set; }

		public uint? DIRECTION { get; set; }

		public string EMPLOYEENAME { get; set; }

		public uint? ES_PCBNUMBER { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public string ESIGMEANINGNAME { get; set; }

		public DateTime? EXPIRATIONDATE { get; set; }

		public string FROMCONTAINER { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMLOT { get; set; }

		public string ISSUECONTROL { get; set; }

		public string ISSUEDETAILS { get; set; }

		public string ISSUEDIFFERENCEREASONNAME { get; set; }

		public string LEADFREE { get; set; }

		public string MFGPARTNUMBER { get; set; }

		public string NICKNAME { get; set; }

		public string PARENTCONTAINERNAME { get; set; }

		public string PARENTPRIMARYSERIALNUMBER { get; set; }

		public string PARENTSERIALNUMBER2 { get; set; }

		public string PARENTSERIALNUMBER3 { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public decimal? QTYREQUIRED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string SHAPENAME { get; set; }

		public string SIGNERFULLNAME { get; set; }

		public string SUPPLIER { get; set; }

		public string SUPPLYFROMNAME { get; set; }

		public string SUPPLYFROMTYPE { get; set; }

		public DateTime? TXNDATE { get; set; }

		public string UOMNAME { get; set; }

		public string VENDORLOTNUMBER { get; set; }

		public string VENDORNAME { get; set; }

		public string WORKFLOWSTEPNAME { get; set; }

	}

}
