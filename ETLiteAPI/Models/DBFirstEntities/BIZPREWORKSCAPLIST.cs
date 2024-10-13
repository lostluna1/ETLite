using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_PREWORKSCAPLIST", DisableSyncStructure = true)]
	public partial class BIZPREWORKSCAPLIST {

		[JsonProperty, Column(Name = "BIZ_PREWORKSCAPLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPREWORKSCAPLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)")]
		public string BIZBUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_DEPTID", DbType = "CHAR(16 BYTE)")]
		public string BIZDEPTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PREWORKSCAPLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZPREWORKSCAPLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PREWORKSCRAPID", DbType = "CHAR(16 BYTE)")]
		public string BIZPREWORKSCRAPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string BU { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string LINE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PRODUCTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SCRAPQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SCRAPRATIO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SCRAPREASON { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCRAPRESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCRAPSPECID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? SCRAPTIME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SCRAPTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIFTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string UOMID { get; set; }

	}

}
