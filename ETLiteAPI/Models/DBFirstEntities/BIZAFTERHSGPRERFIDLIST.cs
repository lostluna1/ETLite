using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZAFTERHSGPRERFIDLIST {

		[JsonProperty, Column(Name = "BIZ_AFTERHSGPRERFIDLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZAFTERHSGPRERFIDLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFERPROCESSINGHSGID", DbType = "CHAR(16 BYTE)")]
		public string BIZAFERPROCESSINGHSGID { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFTERHSGPRERFIDLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZAFTERHSGPRERFIDLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)")]
		public string BIZBUID { get; set; }

		[JsonProperty, Column(Name = "BIZ_RFID", DbType = "CHAR(16 BYTE)")]
		public string BIZRFID { get; set; }

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
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LINEID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ORIGINALQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RFIDEMPNOID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? RFIDOPERATETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SHIFTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
