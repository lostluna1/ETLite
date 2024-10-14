using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISMATQUEUEMATREPDTL {

		public string ISMATQUEUEMATREPDTLID { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public uint? ISFROZEN { get; set; }

		public uint? ISMANUALREPLENISH { get; set; }

		public string ISMATERIALQUEUEID { get; set; }

		public string ISMATQUEUEMATREPDTLNAME { get; set; }

		public string ISPRODUCTID { get; set; }

		public decimal? ISREPLENISHQTY { get; set; }

		public uint? ISREQUESTSUBMITTED { get; set; }

		public uint? ISSEQUENCE { get; set; }

		public decimal? ISTHRESHOLDQTY { get; set; }

		public string ISUOMID { get; set; }

	}

}
