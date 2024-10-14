using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISINVENTORYDETAILS {

		public string ISINVENTORYDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string ISCONTAINERID { get; set; }

		public DateTime? ISEXPIRATIONDATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISINVENTORYDETAILSNAME { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public string ISLOT { get; set; }

		public string ISNAME { get; set; }

		public string ISPRODUCTID { get; set; }

		public decimal? ISQTY { get; set; }

		public uint? ISREMOVALSTRATEGY { get; set; }

		public string ISUOMID { get; set; }

	}

}
