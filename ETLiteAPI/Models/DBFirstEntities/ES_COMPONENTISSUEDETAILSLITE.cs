using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ES_COMPONENTISSUEDETAILSLITE {

		public decimal? ACTUALQTYISSUED { get; set; }

		public string CONTAINERNAME { get; set; }

		public string ES_PRIMARYSERIALNUMBER { get; set; }

		public string ES_SERIALNUMBER2 { get; set; }

		public string ES_SERIALNUMBER3 { get; set; }

		public uint? FAILED { get; set; }

		public string FROMCONTAINERNAME { get; set; }

		public string FROMLOT { get; set; }

		public string FROMPRIMARYSERIALNUMBER { get; set; }

		public string FROMSERIALNUMBER2 { get; set; }

		public string FROMSERIALNUMBER3 { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string IDENTIFIER { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string MFGORDERNAME { get; set; }

		public string PRODUCTMATERIALLISTITEMID { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public uint? STATUS { get; set; }

		public string WORKFLOWNAME { get; set; }

		public string WORKFLOWREVISION { get; set; }

		public uint? XOUT { get; set; }

	}

}
