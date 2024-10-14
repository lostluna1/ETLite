using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPFGCONTAINER {

		[JsonProperty, Column(Name = "BOX_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string BOXNAME { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "E_TEST_DATE", DbType = "DATE(7)")]
		public DateTime? ETESTDATE { get; set; }

		[JsonProperty, Column(Name = "FG_BARCODE", DbType = "VARCHAR2(100 BYTE)")]
		public string FGBARCODE { get; set; }

		[JsonProperty, Column(Name = "FG_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string FGRFID { get; set; }

		[JsonProperty, Column(Name = "MFG_LINE", DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINE { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "PACKING_DATE", DbType = "DATE(7)")]
		public DateTime? PACKINGDATE { get; set; }

		[JsonProperty, Column(Name = "PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

	}

}
