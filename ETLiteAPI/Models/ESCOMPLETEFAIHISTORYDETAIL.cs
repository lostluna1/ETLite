using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_COMPLETEFAIHISTORYDETAIL", DisableSyncStructure = true)]
	public partial class ESCOMPLETEFAIHISTORYDETAIL {

		[JsonProperty, Column(Name = "ES_COMPLETEFAIHISTORYDETAILID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESCOMPLETEFAIHISTORYDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(Name = "ES_COMPLETEFAIHISTORYDETAINAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESCOMPLETEFAIHISTORYDETAINAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYDETAILSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
