using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_MFGORDER", DisableSyncStructure = true)]
	public partial class RVMFGORDER {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FAILCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PANELIZED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PCBCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string PRODUCTDISPLAY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYSTARTED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? XOUTCOUNT { get; set; }

	}

}
