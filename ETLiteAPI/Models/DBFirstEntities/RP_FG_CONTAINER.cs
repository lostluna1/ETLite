using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_FG_CONTAINER {

		public string BOX_NAME { get; set; }

		public DateTime? CREATION_DATE { get; set; }

		public DateTime? E_TEST_DATE { get; set; }

		public string FG_BARCODE { get; set; }

		public string FG_RFID { get; set; }

		public string MFG_LINE { get; set; }

		public string MFGORDER_NAME { get; set; }

		public DateTime? PACKING_DATE { get; set; }

		public string PRODUCT_DESC { get; set; }

		public string PRODUCT_NAME { get; set; }

	}

}
