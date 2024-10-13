using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_PARETO_DEFECTS", DisableSyncStructure = true)]
	public partial class RVPARETODEFECTS {

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISDEFECTREASONNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISREFDES { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARTNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(128 BYTE)")]
		public string PRODUCTDISPLAY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TXNDATE { get; set; }

	}

}
