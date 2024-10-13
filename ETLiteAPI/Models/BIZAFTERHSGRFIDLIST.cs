using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_AFTERHSGRFIDLIST", DisableSyncStructure = true)]
	public partial class BIZAFTERHSGRFIDLIST {

		[JsonProperty, Column(Name = "BIZ_AFTERHSGRFIDLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZAFTERHSGRFIDLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFERPROCESSINGHSGID", DbType = "CHAR(16 BYTE)")]
		public string BIZAFERPROCESSINGHSGID { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFTERHSGRFIDLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZAFTERHSGRFIDLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_BUID", DbType = "CHAR(16 BYTE)")]
		public string BIZBUID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LINEID { get; set; }

		[JsonProperty, Column(Name = "M_RFID", DbType = "CHAR(16 BYTE)")]
		public string MRFID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MATERIALCONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MATERIALCONTAINERNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(Name = "S_RFID", DbType = "CHAR(16 BYTE)")]
		public string SRFID { get; set; }

		[JsonProperty, Column(Name = "S_RFIDEMPNOID", DbType = "CHAR(16 BYTE)")]
		public string SRFIDEMPNOID { get; set; }

		[JsonProperty, Column(Name = "S_RFIDOPERATETIME", DbType = "DATE(7)")]
		public DateTime? SRFIDOPERATETIME { get; set; }

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
