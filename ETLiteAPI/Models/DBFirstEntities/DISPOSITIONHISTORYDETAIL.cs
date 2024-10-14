using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DISPOSITIONHISTORYDETAIL {

		public string DISPOSITIONHISTORYDETAILID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string HISTORYDETAILSID { get; set; }

		public string HISTORYID { get; set; }

		public string INTEGRATIONTXNID { get; set; }

		public string LOT { get; set; }

		public decimal? LOTQUANTITY { get; set; }

		public string PRODUCT { get; set; }

		public decimal? QUANTITYASSIGNED { get; set; }

		public decimal? QUANTITYCONFORMING { get; set; }

		public decimal? QUANTITYDISPOSITIONED { get; set; }

		public string TXNID { get; set; }

		public string UOMNAME { get; set; }

	}

}
