using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class QTYHISTORYDETAILS {

		public string QTYHISTORYDETAILSID { get; set; }

		public uint? ADJUSTTHRUPUT { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? CHANGEQTYTYPE { get; set; }

		public string CHARGETOSTEPID { get; set; }

		public uint? CHILDRENLOST { get; set; }

		public uint? CLOSEWHENZERO { get; set; }

		public string COMMENTS { get; set; }

		public string CONTAINERGRIDREFID { get; set; }

		public string CONTAINERID { get; set; }

		public uint? COUNTSAGAINSTPRODUCTION { get; set; }

		public string ENTEREDQTY { get; set; }

		public string ENTEREDQTY2 { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public uint? ISROLLUP { get; set; }

		public string OPERATIONID { get; set; }

		public string PRODUCTID { get; set; }

		public decimal? QTY { get; set; }

		public decimal? QTY2 { get; set; }

		public string QTYHISTORYID { get; set; }

		public uint? QTYMULTIPLIER { get; set; }

		public string REASONCODEID { get; set; }

		public string REASONCODENAME { get; set; }

		public uint? RECORDALLQTY { get; set; }

		public uint? THISCONTAINERCLOSED { get; set; }

		public uint? THISCONTAINERDISASSOCIATED { get; set; }

		public string TXNID { get; set; }

		public uint? UNITCONTAINER { get; set; }

		public uint? UNITSLOST { get; set; }

		public string UOM2ID { get; set; }

		public string UOMID { get; set; }

		public uint? XLOCATION { get; set; }

		public uint? YLOCATION { get; set; }

		public uint? ZLOCATION { get; set; }

	}

}
