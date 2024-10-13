using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_FG_MATERIAL", DisableSyncStructure = true)]
	public partial class RPFGMATERIAL {

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_BARCODE", DbType = "VARCHAR2(2000 BYTE)")]
		public string MATERIALBARCODE { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_DATE", DbType = "DATE(7)")]
		public DateTime? MATERIALDATE { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string MATERIALPRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string MATERIALPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_QTY", DbType = "NUMBER(22)")]
		public decimal? MATERIALQTY { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_UOM", DbType = "VARCHAR2(30 BYTE)")]
		public string MATERIALUOM { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

	}

}
