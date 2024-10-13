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
	public partial class ACTIVITYTEMPLATE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ACTIVITYTEMPLATEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ACTIVITYTEMPLATENAME { get; set; }

		[JsonProperty]
		public uint? ALLOWREASSIGNMENT { get; set; }

		[JsonProperty]
		public uint? APPROVALREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEEID { get; set; }

		[JsonProperty]
		public uint? ASSIGNEEOPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEEROLEID { get; set; }

		[JsonProperty]
		public uint? AUTOCOMPLETE { get; set; }

		[JsonProperty]
		public uint? AUTOEXECUTE { get; set; }

		[JsonProperty]
		public uint? AUTOSTART { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHANGEHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHECKLISTID { get; set; }

		[JsonProperty]
		public uint? COMPLETEWITHINQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(12,6)")]
		public decimal? COMPLETEWITHINUOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATACOLLECTIONDEFID { get; set; }

		[JsonProperty]
		public uint? DEFAULTASSIGNEEINFO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DISPLAYCONFORMINGQUANTITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DISPOSITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "CLOB")]
		public string FILTERTAGS { get; set; }

		[JsonProperty]
		public uint? ICONID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string NOTES { get; set; }

		[JsonProperty]
		public uint? RECONCILEQUANTITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

	}

}
