using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class HVREMOVEHISTORYDETAIL {

		public string HVREMOVEHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CONTAINERID { get; set; }

		public string DESTINATIONLOT { get; set; }

		public string DESTINATIONSTOCKPOINT { get; set; }

		public string ENTEREDQTYREMOVED { get; set; }

		public string HISTORYID { get; set; }

		public string HVISSUEHISTORYDETAILID { get; set; }

		public string HVREMOVEHISTORYDETAILNAME { get; set; }

		public string HVSETUPDETAILID { get; set; }

		public string HVSETUPID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string MATERIALLISTITEMID { get; set; }

		public string NOTES { get; set; }

		public string PARENTID { get; set; }

		public decimal? QTYREMOVED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string REMOVALREASONID { get; set; }

		public string REMOVEDIFFERENCEREASONID { get; set; }

		public string SPECID { get; set; }

		public DateTime? TXNDATEGMT { get; set; }

		public string TXNID { get; set; }

		public string WORKFLOWSTEPID { get; set; }

	}

}
