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
	public partial class TRIAGEQUALITYOBJECTHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESCALATEQUALITYOBJECTHISTORYID { get; set; }

		[JsonProperty]
		public uint? CATEGORY { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty]
		public uint? ISCARREQUIREDTOCLOSE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYLEVELID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSMODELTEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYOBJECTOWNERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYOBJECTROLEID { get; set; }

		[JsonProperty]
		public uint? ROUTEPROCESSMODEL { get; set; }

		[JsonProperty]
		public uint? TRIAGECOMPLETE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRIAGESPECDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
