using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISREPLENISHTHRESHOLDDETAILS {

		public string ISREPLENISHTHRESHOLDDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public string ISPRODUCTID { get; set; }

		public string ISREPLENISHTHRESHOLDDETAILNAME { get; set; }

		public decimal? ISREPLENISHTHRESHOLDQTY { get; set; }

		public string ISREPLENISHTHRESHOLDUOMID { get; set; }

	}

}
