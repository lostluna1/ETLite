using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_ORDERREPORT", DisableSyncStructure = true)]
	public partial class RPORDERREPORT {

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string BIZBUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUSTOMERPRODUCT", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCUSTOMERPRODUCT { get; set; }

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
		public string ETUOMNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string FACTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string FACTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FQCNGQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FQCPASSQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MANPOWER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MFGLINENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MFGORDERNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string MTUOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERSTATUSNAME { get; set; }

		[JsonProperty, Column(Name = "ORDERTYP_DESCRIPTION", DbType = "VARCHAR2(255 BYTE)")]
		public string ORDERTYPDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ORDERTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PLANNEDSTARTDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME1 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME2 { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PTDESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SHIFTBACKQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SHIFTCOMPLATEQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SHIFTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string STARTTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SYSDATETIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? WOCOMPLETEDATE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? WOQTY { get; set; }

	}

}
