using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIN {

		public string BINID { get; set; }

		public string BINNAME { get; set; }

		public decimal? BINPERCENTAGE { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string DESCRIPTION { get; set; }

		public DateTime? EFFECTIVEFROMDATE { get; set; }

		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		public DateTime? EFFECTIVETHRUDATE { get; set; }

		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		public string EXPORTIMPORTKEY { get; set; }

		public string FROMPRODUCTBASEID { get; set; }

		public string FROMPRODUCTID { get; set; }

		public uint? ISFROZEN { get; set; }

		public string NOTES { get; set; }

		public string PATHID { get; set; }

		public string RESULTINGPRODUCTBASEID { get; set; }

		public string RESULTINGPRODUCTID { get; set; }

		public uint? STATUS { get; set; }

		public string STEPID { get; set; }

		public string TXNDETAILSID { get; set; }

	}

}
