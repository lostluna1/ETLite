using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZ_PRODUCTLIST {

		public string BIZ_PRODUCTLISTID { get; set; }

		public string BIZ_MODELMAPPRODUCTID { get; set; }

		public string BIZ_PRODUCTLISTNAME { get; set; }

		public uint? CDOTYPEID { get; set; }

		public uint? CHANGECOUNT { get; set; }

		public string CUSTOMERID { get; set; }

		public string DESCRIPTION { get; set; }

		public uint? ENABLE { get; set; }

		public string EOL { get; set; }

		public uint? ISFROZEN { get; set; }

		public string PRODUCTID { get; set; }

	}

}
