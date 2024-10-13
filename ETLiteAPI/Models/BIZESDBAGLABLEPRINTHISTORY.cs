using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_ESDBAGLABLEPRINTHISTORY", DisableSyncStructure = true)]
	public partial class BIZESDBAGLABLEPRINTHISTORY {

		[JsonProperty, Column(Name = "BIZ_ESDBAGLABLEPRINTHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZESDBAGLABLEPRINTHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string ATESN { get; set; }

		[JsonProperty, Column(Name = "BIZ_ESDBAGLABLEPRINTHISTORNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZESDBAGLABLEPRINTHISTORNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string CPN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string DC { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESDBAGLABLESNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTPRINTINGEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTPRINTINGTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string MODEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string OPN { get; set; }

		[JsonProperty]
		public uint? PRINTINGTIMES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
