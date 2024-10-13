using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_CRITICAL_SPEC_DASHBOARD_WIP_NEW", DisableSyncStructure = true)]
	public partial class RPCRITICALSPECDASHBOARDWIPNEW {

		[JsonProperty, Column(Name = "CREATION_DATE", DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(Name = "LAST_PASS_QTY", DbType = "NUMBER(22)")]
		public decimal? LASTPASSQTY { get; set; }

		[JsonProperty, Column(Name = "LAST_SEQ", DbType = "NUMBER(22)")]
		public decimal? LASTSEQ { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(Name = "PASS_QTY", DbType = "NUMBER(22)")]
		public decimal? PASSQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "SPEC_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string SPECDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SPECNAME { get; set; }

		[JsonProperty, Column(Name = "WIP_QTY", DbType = "NUMBER(22)")]
		public decimal? WIPQTY { get; set; }

		[JsonProperty, Column(Name = "WO_QTY", DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
