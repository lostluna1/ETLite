using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPMATERIALQTY {

		[JsonProperty, Column(Name = "MATERIAL_PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string MATERIALPRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string MATERIALPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_QTY", DbType = "NUMBER(22)")]
		public decimal? MATERIALQTY { get; set; }

		[JsonProperty, Column(Name = "MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

	}

}
