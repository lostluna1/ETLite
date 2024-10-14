using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISSUEHISTORYDETAIL {

		public string ISSUEHISTORYDETAILID { get; set; }

		public decimal? ACTUALQTY2ISSUED { get; set; }

		public decimal? ACTUALQTYISSUED { get; set; }

		public uint? ALLOWMANUALWEIGHOVERRIDE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CLOSEWHENEMPTY { get; set; }

		public string COMPONENTISSUEHISTORYID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISMANUALREADINGONLY { get; set; }

		public uint? ISSUECONTROL { get; set; }

		public string ISSUEDIFFERENCEREASONID { get; set; }

		public string NOTES { get; set; }

		public string PRODUCTID { get; set; }

		public string PRODUCTMATERIALLISTITEMID { get; set; }

		public decimal? QTY2REQUIRED { get; set; }

		public decimal? QTYLOWERLIMIT { get; set; }

		public decimal? QTYREQUIRED { get; set; }

		public decimal? QTYUPPERLIMIT { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string TXNID { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

	}

}
