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
	public partial class ERPBOM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BILLTYPEID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BOMTYPE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZBOMTYPE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EFFECTIVEFROMDATE", DbType = "DATE(7)")]
		public DateTime? BIZEFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_EFFECTIVETHROUGHDATE", DbType = "DATE(7)")]
		public DateTime? BIZEFFECTIVETHROUGHDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_STATUS", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZSTATUS { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ECO { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(25 BYTE)")]
		public string ERPBOMREVISION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEID { get; set; }

		[JsonProperty]
		public uint? EXTERNALLYCONTROLLED { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WIPMSGDEFMGRID { get; set; }

	}

}
