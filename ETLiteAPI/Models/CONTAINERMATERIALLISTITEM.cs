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
	public partial class CONTAINERMATERIALLISTITEM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERMATERIALLISTITEMID { get; set; }

		[JsonProperty]
		public uint? ALLOWOVERCONSUMPTION { get; set; }

		[JsonProperty]
		public uint? ALLOWSUBSTITUTION { get; set; }

		[JsonProperty]
		public uint? ALLOWUNDERCONSUMPTION { get; set; }

		[JsonProperty]
		public uint? ASSEMBLYSEQUENCE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERMATERIALLISTITEMNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEFAULTLOT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string DEFAULTSTOCKPOINT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ERPLINEITEM { get; set; }

		[JsonProperty]
		public uint? ERPREPORTINGFLAG { get; set; }

		[JsonProperty, Column(Name = "ES_MOUNTINGTECHNOLOGY")]
		public uint? ESMOUNTINGTECHNOLOGY { get; set; }

		[JsonProperty, Column(Name = "ES_PCBSIDE")]
		public uint? ESPCBSIDE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISENABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISIMAGEID { get; set; }

		[JsonProperty]
		public uint? ISPHANTOM { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ISPRODUCTDESCRIPTION { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHANTOMBILLID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCINGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2REQUIRED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROUTESTEPID { get; set; }

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

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SUBFACTORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty]
		public uint? VENDORCONTROL { get; set; }

	}

}
