using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_PRODEFFALLVIEW", DisableSyncStructure = true)]
	public partial class RPPRODEFFALLVIEW {

		[JsonProperty, Column(Name = "ACTIVATION_RATE", DbType = "NUMBER(22)")]
		public decimal? ACTIVATIONRATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CALENDARDAY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PRDRATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR1 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR3 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR4 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR5 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR6 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? VAR7 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WORKRATE { get; set; }

	}

}
