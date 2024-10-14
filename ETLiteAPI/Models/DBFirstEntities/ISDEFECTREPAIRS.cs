using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ISDEFECTREPAIRS {

		public string CHILDID { get; set; }

		public string ISDEFECTHISTORYDETAILID { get; set; }

		public string ISDEFECTREASONID { get; set; }

		public string ISREFDES { get; set; }

		public string ISREPAIRACTIONID { get; set; }

		public string ISREPAIRACTIONNAME { get; set; }

		public uint? ISX { get; set; }

		public uint? ISY { get; set; }

		public string PRODUCTID { get; set; }

	}

}
