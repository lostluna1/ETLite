using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class RPKANBANDATA {

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMERPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? COMPLETEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FQCNGQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MANPOWER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME1 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TESTQTYS { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
