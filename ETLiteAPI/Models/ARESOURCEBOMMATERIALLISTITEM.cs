using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "A_RESOURCEBOMMATERIALLISTITEM", DisableSyncStructure = true)]
	public partial class ARESOURCEBOMMATERIALLISTITEM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RESOURCEBOMMATERIALLISTITEMID { get; set; }

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

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHRUDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISENABLED { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISPHANTOM { get; set; }

		[JsonProperty]
		public uint? ISSOURCEPRODUCT { get; set; }

		[JsonProperty]
		public uint? ISSUECONTROL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PHANTOMBILLID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string PRODUCINGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY2REQUIRED { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string REFERENCEDESIGNATOR { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEBOMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCEBOMMATERIALLISTITENAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCRAPPERCENT { get; set; }

		[JsonProperty]
		public uint? SCSISCOMPONENTISSUE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPQTY2 { get; set; }

		[JsonProperty, Column(Name = "SS_STEPID", DbType = "CHAR(16 BYTE)")]
		public string SSSTEPID { get; set; }

		[JsonProperty, Column(Name = "SS_WFSTACKKEY", DbType = "VARCHAR2(255 BYTE)")]
		public string SSWFSTACKKEY { get; set; }

		[JsonProperty, Column(Name = "SS_WORKFLOWID", DbType = "CHAR(16 BYTE)")]
		public string SSWORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOM2ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

		[JsonProperty]
		public uint? VENDORCONTROL { get; set; }

	}

}
