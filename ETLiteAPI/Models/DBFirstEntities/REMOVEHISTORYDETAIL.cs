using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class REMOVEHISTORYDETAIL {

		public string REMOVEHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string COMPONENTREMOVEHISTORYID { get; set; }

		public string DESTINATIONCONTAINERID { get; set; }

		public string DESTINATIONLOCATIONID { get; set; }

		public string DESTINATIONLOT { get; set; }

		public string DESTINATIONSTOCKPOINT { get; set; }

		public string ENTEREDQTY2REMOVED { get; set; }

		public string ENTEREDQTYREMOVED { get; set; }

		public string ES_DESTINATIONLOT2 { get; set; }

		public string ES_DESTINATIONLOT3 { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string ISSUEACTUALSHISTORYID { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string NOTES { get; set; }

		public uint? OPENCLOSEDCONTAINER { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY2REMOVED { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REMOVALREASONID { get; set; }

		public uint? REMOVEALLQTY { get; set; }

		public string REMOVEDIFFERENCEREASONID { get; set; }

		public string REPLACEFROMCONTAINERID { get; set; }

		public string REPLACEFROMLOT { get; set; }

		public string REPLACEFROMSTOCKPOINT { get; set; }

		public string REPLACEISSUEDIFFERENCEREASONID { get; set; }

		public string REPLACEISSUEREASONID { get; set; }

		public decimal? REPLACEQTY2ISSUED { get; set; }

		public decimal? REPLACEQTYISSUED { get; set; }

		public string TXNID { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

	}

}
