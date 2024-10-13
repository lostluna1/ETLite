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
	public partial class SIGNAPPROVALHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SIGNAPPROVALHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? APPROVALCYCLE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? APPROVALCYCLEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVALDECISIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVALSHEETENTRYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVALSHEETID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVEDBYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVERROLEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBYGMT { get; set; }

		[JsonProperty]
		public uint? DECISIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTROUTEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTROUTEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYOBJECTID { get; set; }

		[JsonProperty]
		public uint? SHEETLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SPECIALINSTRUCTIONS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRACKABLEOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
