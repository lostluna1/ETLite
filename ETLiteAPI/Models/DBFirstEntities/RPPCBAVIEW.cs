using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_PCBAVIEW", DisableSyncStructure = true)]
	public partial class RPPCBAVIEW {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? COMQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? DIFF { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXTDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
