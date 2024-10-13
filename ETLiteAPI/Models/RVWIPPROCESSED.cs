using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_WIP_PROCESSED", DisableSyncStructure = true)]
	public partial class RVWIPPROCESSED {

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(5 BYTE)")]
		public string ISFAILED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEINDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MOVEOUTDATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string NEXTSTEP { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string PREVSTEP { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string STEPDISPLAYNAME { get; set; }

	}

}
