using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPSUBMATERIAL {

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "FG_MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string FGMFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_BARCODE", DbType = "VARCHAR2(2000 BYTE)")]
		public string MATERIALBARCODE { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_DATE", DbType = "DATE(7)")]
		public DateTime? MATERIALDATE { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string MATERIALPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_QTY", DbType = "NUMBER(22)")]
		public decimal? MATERIALQTY { get; set; }

		[JsonProperty, Column(Name = "MATERIAL_UOM", DbType = "VARCHAR2(30 BYTE)")]
		public string MATERIALUOM { get; set; }

		[JsonProperty, Column(Name = "MATERIL_CONTAINER_ID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MATERILCONTAINERID { get; set; }

		[JsonProperty, Column(Name = "SUB_CONTAINER_ID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string SUBCONTAINERID { get; set; }

		[JsonProperty, Column(Name = "SUB_MFG_LINE", DbType = "VARCHAR2(40 BYTE)")]
		public string SUBMFGLINE { get; set; }

		[JsonProperty, Column(Name = "SUB_MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string SUBMFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string SUBPRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "SUB_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string SUBPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string SUBRFID { get; set; }

		[JsonProperty, Column(Name = "SUB_RFID_ID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string SUBRFIDID { get; set; }

	}

}
