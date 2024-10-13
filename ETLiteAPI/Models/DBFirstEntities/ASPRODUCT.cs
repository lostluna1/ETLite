using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "AS_PRODUCT", DisableSyncStructure = true)]
	public partial class ASPRODUCT {

		[JsonProperty, Column(Name = "BIZ_ASSEMBLYSCRAPRATE", DbType = "NUMBER(22)")]
		public decimal? BIZASSEMBLYSCRAPRATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBUNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_EXTPRODUCT", DbType = "VARCHAR2(255 BYTE)")]
		public string BIZEXTPRODUCT { get; set; }

		[JsonProperty, Column(Name = "BIZ_GROSSWEIGHT", DbType = "NUMBER(22)")]
		public decimal? BIZGROSSWEIGHT { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATERIALFAMILYNAME", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZMATERIALFAMILYNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_MATERIALLT")]
		public uint? BIZMATERIALLT { get; set; }

		[JsonProperty, Column(Name = "BIZ_MRPCONTROLLER", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZMRPCONTROLLER { get; set; }

		[JsonProperty, Column(Name = "BIZ_MULTPSTATUSEFFSTARTDATE", DbType = "DATE(7)")]
		public DateTime? BIZMULTPSTATUSEFFSTARTDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_NETWEIGHT", DbType = "NUMBER(22)")]
		public decimal? BIZNETWEIGHT { get; set; }

		[JsonProperty, Column(Name = "BIZ_PACKINGQTY", DbType = "NUMBER(22)")]
		public decimal? BIZPACKINGQTY { get; set; }

		[JsonProperty, Column(Name = "BIZ_POTYPENAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZPOTYPENAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_SCRAPRATE", DbType = "NUMBER(22)")]
		public decimal? BIZSCRAPRATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SELFPRODUCTIONDAY")]
		public uint? BIZSELFPRODUCTIONDAY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SINGLEPSTATUSEFFSTARTDATE", DbType = "DATE(7)")]
		public DateTime? BIZSINGLEPSTATUSEFFSTARTDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SPECIALPOTYPENAME", DbType = "VARCHAR2(64 BYTE)")]
		public string BIZSPECIALPOTYPENAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_STDCOSTPRICE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSTDCOSTPRICE { get; set; }

		[JsonProperty, Column(Name = "BIZ_STORAGELOCATION", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSTORAGELOCATION { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUPPLYTYPE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSUPPLYTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string EXSBSPECNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MULTISTATUSMATERIALSTATUSNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string NETUOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTFAMILYNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string PRODUCTREVISION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string SINGLESTATUSMATERIALSTATUSNAME { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string UOMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WHSBSPECNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(15 BYTE)")]
		public string WORKFLOWREVISION { get; set; }

	}

}
