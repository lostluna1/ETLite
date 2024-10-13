using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_HOURLY_EFFICIENCY", DisableSyncStructure = true)]
	public partial class RPHOURLYEFFICIENCY {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ACTUALOUTPUT { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BREAKTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ENDTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FQCNGQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FQCPASSQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MANPOWER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NGQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANNEDOUTPUT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SHIFTBACKQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SHIFTCOMPLATEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string STARTTIME { get; set; }

	}

}
