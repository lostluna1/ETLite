using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPSUBFG {

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(Name = "FG_BARCODE", DbType = "VARCHAR2(100 BYTE)")]
		public string FGBARCODE { get; set; }

		[JsonProperty, Column(Name = "FG_CONTAINER_ID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string FGCONTAINERID { get; set; }

		[JsonProperty, Column(Name = "FG_MFGORDER_ID", DbType = "CHAR(16 BYTE)")]
		public string FGMFGORDERID { get; set; }

		[JsonProperty, Column(Name = "FG_MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string FGMFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "FG_PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string FGPRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "FG_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string FGPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "FG_QTY")]
		public uint? FGQTY { get; set; }

		[JsonProperty, Column(Name = "FG_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string FGRFID { get; set; }

		[JsonProperty, Column(Name = "ORIGINAL_STARTDATE", DbType = "DATE(7)")]
		public DateTime? ORIGINALSTARTDATE { get; set; }

		[JsonProperty, Column(Name = "RFID_OPERATETIME", DbType = "DATE(7)")]
		public DateTime? RFIDOPERATETIME { get; set; }

		[JsonProperty, Column(Name = "SUB_BARCODE", DbType = "VARCHAR2(100 BYTE)")]
		public string SUBBARCODE { get; set; }

		[JsonProperty, Column(Name = "SUB_CONTAINER_ID", DbType = "CHAR(16 BYTE)")]
		public string SUBCONTAINERID { get; set; }

		[JsonProperty, Column(Name = "SUB_MATERIAL_QTY", DbType = "NUMBER(22)")]
		public decimal? SUBMATERIALQTY { get; set; }

		[JsonProperty, Column(Name = "SUB_MFGORDER_ID", DbType = "CHAR(16 BYTE)")]
		public string SUBMFGORDERID { get; set; }

		[JsonProperty, Column(Name = "SUB_MFGORDER_NAME", DbType = "VARCHAR2(30 BYTE)")]
		public string SUBMFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_PRODUCT_DESC", DbType = "VARCHAR2(255 BYTE)")]
		public string SUBPRODUCTDESC { get; set; }

		[JsonProperty, Column(Name = "SUB_PRODUCT_NAME", DbType = "VARCHAR2(100 BYTE)")]
		public string SUBPRODUCTNAME { get; set; }

		[JsonProperty, Column(Name = "SUB_QTY")]
		public uint? SUBQTY { get; set; }

		[JsonProperty, Column(Name = "SUB_RFID", DbType = "VARCHAR2(64 BYTE)")]
		public string SUBRFID { get; set; }

		[JsonProperty, Column(Name = "SUB_RFID_ID", DbType = "CHAR(16 BYTE)")]
		public string SUBRFIDID { get; set; }

	}

}
