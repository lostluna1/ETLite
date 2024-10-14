using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class EVENTLOTHISTORYDETAIL {

		public string EVENTLOTHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public string CONTAINERID { get; set; }

		public string EVENTDATAHISTORYDETAILID { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FACTORYNAME { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISCONTAINER { get; set; }

		public string LOT { get; set; }

		public string OPERATIONNAME { get; set; }

		public DateTime? ORIGINALSTARTDATE { get; set; }

		public uint? PLACEONHOLD { get; set; }

		public string PRODUCTDESCRIPTION { get; set; }

		public string PRODUCTNAME { get; set; }

		public string PRODUCTREV { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTYDEFECTIVE { get; set; }

		public decimal? QTYSAMPLED { get; set; }

		public string REFERENCEDESIGNATOR { get; set; }

		public string TASKID { get; set; }

		public string TXNID { get; set; }

		public string UOMNAME { get; set; }

		public string WORKCENTERNAME { get; set; }

	}

}
