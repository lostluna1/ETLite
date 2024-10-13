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
	public partial class APPROVALSHEETENTRY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string APPROVALSHEETENTRYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVALDECISIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVEDBYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string APPROVERROLEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEDAPPROVERID { get; set; }

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
		public uint? COMPLETEWITHINQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(12,6)")]
		public decimal? COMPLETEWITHINUOM { get; set; }

		[JsonProperty]
		public uint? DECISIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DELEGATIONTASKID { get; set; }

		[JsonProperty]
		public uint? EDITOPTION { get; set; }

		[JsonProperty]
		public uint? ENTRYREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTROUTEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTROUTEDONGMT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTDECISIONID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTROUTEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTROUTEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PLMAPPROVALCODE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(512 BYTE)")]
		public string PLMAPPROVALURL { get; set; }

		[JsonProperty]
		public uint? SHEETLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SPECIALINSTRUCTIONS { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty]
		public uint? SUBSTITUTEOPTION { get; set; }

	}

}
