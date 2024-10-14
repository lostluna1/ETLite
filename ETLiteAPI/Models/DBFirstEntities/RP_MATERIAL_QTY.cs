using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_MATERIAL_QTY {

		public string MATERIAL_PRODUCT_DESC { get; set; }

		public string MATERIAL_PRODUCT_NAME { get; set; }

		public decimal? MATERIAL_QTY { get; set; }

		public string MFGORDER_NAME { get; set; }

		public string PRODUCTID { get; set; }

	}

}
