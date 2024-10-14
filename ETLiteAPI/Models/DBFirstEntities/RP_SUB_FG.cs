using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RP_SUB_FG {

		public DateTime? CREATION_DATE { get; set; }

		public string FG_BARCODE { get; set; }

		public string FG_CONTAINER_ID { get; set; }

		public string FG_MFGORDER_ID { get; set; }

		public string FG_MFGORDER_NAME { get; set; }

		public string FG_PRODUCT_DESC { get; set; }

		public string FG_PRODUCT_NAME { get; set; }

		public uint? FG_QTY { get; set; }

		public string FG_RFID { get; set; }

		public DateTime? ORIGINAL_STARTDATE { get; set; }

		public DateTime? RFID_OPERATETIME { get; set; }

		public string SUB_BARCODE { get; set; }

		public string SUB_CONTAINER_ID { get; set; }

		public decimal? SUB_MATERIAL_QTY { get; set; }

		public string SUB_MFGORDER_ID { get; set; }

		public string SUB_MFGORDER_NAME { get; set; }

		public string SUB_PRODUCT_DESC { get; set; }

		public string SUB_PRODUCT_NAME { get; set; }

		public uint? SUB_QTY { get; set; }

		public string SUB_RFID { get; set; }

		public string SUB_RFID_ID { get; set; }

	}

}
