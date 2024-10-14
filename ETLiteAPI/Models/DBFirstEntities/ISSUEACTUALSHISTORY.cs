using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISSUEACTUALSHISTORY {

		public string ISSUEACTUALSHISTORYID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ENTEREDQTY2ISSUED { get; set; }

		public string ENTEREDQTYISSUED { get; set; }

		public string ES_FROMLOT2 { get; set; }

		public string ES_FROMLOT3 { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FEEDERBANKID { get; set; }

		public string FEEDERID { get; set; }

		public string FEEDERSLOTID { get; set; }

		public string FROMBATCHID { get; set; }

		public string FROMCARRIERID { get; set; }

		public string FROMCONTAINERID { get; set; }

		public string FROMLOCATIONID { get; set; }

		public string FROMLOT { get; set; }

		public string FROMSTOCKPOINT { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISAUTOWEIGHTENTRY { get; set; }

		public string ISMATERIALQUEUEDETAILSID { get; set; }

		public string ISSUEDIFFERENCEREASONID { get; set; }

		public string ISSUEHISTORYDETAILID { get; set; }

		public string ISSUEREASONID { get; set; }

		public uint? MANUALOVERRIDE { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTDESCRIPTION { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REPLACEPRODUCTID { get; set; }

		public string RESOURCEID { get; set; }

		public string SUBSTITUTIONREASONID { get; set; }

		public string TOCONTAINERID { get; set; }

		public string TOLOCATIONID { get; set; }

		public string TXNID { get; set; }

		public string VENDORITEMID { get; set; }

	}

}
