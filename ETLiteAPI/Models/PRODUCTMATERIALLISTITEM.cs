using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class PRODUCTMATERIALLISTITEM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string PRODUCTMATERIALLISTITEMID { get; set; }

		[JsonProperty]
		public uint? ALLOWOVERCONSUMPTION { get; set; }

		[JsonProperty]
		public uint? ALLOWSUBSTITUTION { get; set; }

		[JsonProperty]
		public uint? ALLOWUNDERCONSUMPTION { get; set; }

		[JsonProperty]
		public uint? ASSEMBLYSEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_BASEQUANTITY", DbType = "NUMBER(22)")]
		public decimal? BIZBASEQUANTITY { get; set; }

		[JsonProperty, Column(Name = "BIZ_BASEREQUIRED", DbType = "NUMBER(22)")]
		public decimal? BIZBASEREQUIRED { get; set; }

		[JsonProperty, Column(Name = "BIZ_COMMENT1", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCOMMENT1 { get; set; }

		[JsonProperty, Column(Name = "BIZ_COMMENT2", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZCOMMENT2 { get; set; }

		[JsonProperty, Column(Name = "BIZ_FEEDWHID", DbType = "CHAR(16 BYTE)")]
		public string BIZFEEDWHID { get; set; }

		[JsonProperty, Column(Name = "BIZ_OLDMATERIALMARK", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZOLDMATERIALMARK { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBSTITUTIONGROUP", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSUBSTITUTIONGROUP { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBSTITUTIONPERCENTAGE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSUBSTITUTIONPERCENTAGE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBSTITUTIONPRIORITY", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSUBSTITUTIONPRIORITY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUBSTITUTIONSTRATGY", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSUBSTITUTIONSTRATGY { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUPPLYTYPE", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZSUPPLYTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SUPPLYTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZSUPPLYTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_TOTALREQUIRED", DbType = "VARCHAR2(30 BYTE)")]
		public string BIZTOTALREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(Name = "ES_PCBSIDE")]
		public uint? ESPCBSIDE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISIMAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ISPRODUCTDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? MATERIALTXNLOGIC { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHANTOMBILLID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCINGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTMATERIALLISTITEMNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2REQUIRED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCRAPPERCENT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPQTY2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty]
		public uint? VENDORCONTROL { get; set; }

	}

}
