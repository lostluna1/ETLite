using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class DELETERPDASHBOARDDATA {

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ADDQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EQTTIME", DbType = "NUMBER(22)")]
		public decimal? BIZEQTTIME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANTIME", DbType = "NUMBER(22)")]
		public decimal? BIZMANTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BREAKTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? COMPLETEQTY { get; set; }

		[JsonProperty, Column(Name = "CUSTOMER_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string CUSTOMERDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CUSTOMERNAME { get; set; }

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

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? PLANQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME1 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SHIFTCOMPLATEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string STARTTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
