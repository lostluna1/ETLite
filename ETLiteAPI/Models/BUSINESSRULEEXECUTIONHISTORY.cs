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
	public partial class BUSINESSRULEEXECUTIONHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BUSINESSRULEEXECUTIONHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(1000 BYTE)")]
		public string BUSINESSRULECONDITION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string BUSINESSRULENAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string CONTEXTDISPLAYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTEXTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string CONTEXTTYPENAME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXECUTIONTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXECUTIONTIMEGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
