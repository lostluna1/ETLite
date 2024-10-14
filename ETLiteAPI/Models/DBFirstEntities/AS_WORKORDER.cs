using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class AS_WORKORDER {

		public string BIZ_COMPLETIONWAREHOUSE { get; set; }

		public string BIZ_CUSTOMER { get; set; }

		public string BIZ_CUSTOMERPRODUCT { get; set; }

		public string BIZ_FATHERMFGORDER { get; set; }

		public string BIZ_FEEDWH { get; set; }

		public string BIZ_FGWAREHOUSE { get; set; }

		public string BIZ_PO { get; set; }

		public DateTime? BIZ_SHIPPINGDATE { get; set; }

		public string BIZ_SO { get; set; }

		public string BIZ_SONUM { get; set; }

		public string BIZ_SUPPLYTYPE { get; set; }

		public string BIZ_TOPMO { get; set; }

		public string BIZ_TOTALREQUIRED { get; set; }

		public string BOMUOM { get; set; }

		public string ERPLINEITEM { get; set; }

		public string ERPROUTE { get; set; }

		public string ERPROUTEREVISION { get; set; }

		public string MATERIAL { get; set; }

		public string MATERIALREVISION { get; set; }

		public uint? MATERIALTXNLOGIC { get; set; }

		public string MFGLINE { get; set; }

		public string MFGORDER { get; set; }

		public decimal? ORDERQTY { get; set; }

		public string ORDERSTATUS { get; set; }

		public string ORDERTYPE { get; set; }

		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		public DateTime? PLANNEDSTARTDATE { get; set; }

		public string PRODUCT { get; set; }

		public string PRODUCTIONREVISION { get; set; }

		public string PRODUCTREVISION { get; set; }

		public decimal? QUANTITYREQUIRED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REPORTINGFACTORY { get; set; }

		public string SPEC { get; set; }

		public string SPECREVISION { get; set; }

		public string UOM { get; set; }

	}

}
