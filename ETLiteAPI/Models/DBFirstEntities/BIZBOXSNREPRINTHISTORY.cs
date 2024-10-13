using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_BOXSNREPRINTHISTORY", DisableSyncStructure = true)]
	public partial class BIZBOXSNREPRINTHISTORY {

		[JsonProperty, Column(Name = "BIZ_BOXSNREPRINTHISTORYID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZBOXSNREPRINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BOXLABLEPRINTHISTORYID", DbType = "CHAR(16 BYTE)")]
		public string BIZBOXLABLEPRINTHISTORYID { get; set; }

		[JsonProperty, Column(Name = "BIZ_BOXSNREPRINTHISTORYNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZBOXSNREPRINTHISTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOXSNID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISWIPLABEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string LABELTEMPLATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MFGORDERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PREVIOUSEMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PREVIOUSTIME { get; set; }

		[JsonProperty]
		public uint? PRINTCOUNT { get; set; }

		[JsonProperty]
		public uint? REPRINTCOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
