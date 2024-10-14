using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_FG_MATERIAL {

		public DateTime? CREATION_DATE { get; set; }

		public string MATERIAL_BARCODE { get; set; }

		public DateTime? MATERIAL_DATE { get; set; }

		public string MATERIAL_PRODUCT_DESC { get; set; }

		public string MATERIAL_PRODUCT_NAME { get; set; }

		public decimal? MATERIAL_QTY { get; set; }

		public string MATERIAL_UOM { get; set; }

		public string MFGORDER_NAME { get; set; }

	}

}
