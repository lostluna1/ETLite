using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATERIALQUEUEDETAILS {

		public string ISMATERIALQUEUEDETAILSID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public decimal? ISCONSUMEDQTY { get; set; }

		public string ISCONTAINERID { get; set; }

		public uint? ISERP { get; set; }

		public DateTime? ISEXPIRATIONDATE { get; set; }

		public uint? ISFROZEN { get; set; }

		public string ISINVENTORYLOCATIONID { get; set; }

		public string ISLOT { get; set; }

		public uint? ISMANUALCONSUMED { get; set; }

		public string ISMATERIALQUEUEDETAILSNAME { get; set; }

		public string ISMATERIALQUEUEID { get; set; }

		public string ISNAME { get; set; }

		public string ISPRODUCTID { get; set; }

		public decimal? ISQTY { get; set; }

		public decimal? ISQTYAVAILABLE { get; set; }

		public uint? ISREMOVALSTRATEGY { get; set; }

		public uint? ISSEQUENCE { get; set; }

		public string ISUOMID { get; set; }

	}

}
