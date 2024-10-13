using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_SVCTAGSNPRINTHISTORY", DisableSyncStructure = true)]
	public partial class BIZSVCTAGSNPRINTHISTORY {

		[JsonProperty, Column(Name = "BIZ_SVCTAGSNPRINTHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZSVCTAGSNPRINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_DATE", DbType = "VARCHAR2(40 BYTE)")]
		public string BIZDATE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SVCTAGSNPRINTHISTORYNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZSVCTAGSNPRINTHISTORYNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_SVCTAGSNPRINTID", DbType = "CHAR(16 BYTE)")]
		public string BIZSVCTAGSNPRINTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty]
		public uint? CONTAINERTYPE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CREATORID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DOCKREV { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string DPN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LABELTEMPLATE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MAC { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string MFGDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PPID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PPIDVIEW { get; set; }

		[JsonProperty]
		public uint? PRINTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string SERVICECODE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string STPPID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WT { get; set; }

	}

}
