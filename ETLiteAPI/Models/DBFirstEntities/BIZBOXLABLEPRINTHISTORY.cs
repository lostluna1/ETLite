using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_BOXLABLEPRINTHISTORY", DisableSyncStructure = true)]
	public partial class BIZBOXLABLEPRINTHISTORY {

		[JsonProperty, Column(Name = "BIZ_BOXLABLEPRINTHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZBOXLABLEPRINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BOXLABLEPRINTHISTORYNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZBOXLABLEPRINTHISTORYNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_BOXSNREPRINTHISTORYID", DbType = "CHAR(16 BYTE)")]
		public string BIZBOXSNREPRINTHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOXSNID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CUSTOMERPN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CUSTOMERPO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CUSTOMERREV { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? GROSSWEIGHT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISREPRINT { get; set; }

		[JsonProperty]
		public uint? ISWIPLABEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LABELTEMPLATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTPRINTINGEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTPRINTINGTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NETWEIGHT { get; set; }

		[JsonProperty]
		public uint? PRINTINGTIMES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? QTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
