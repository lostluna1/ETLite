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
	public partial class ACTIVITY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ACTIVITYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ACTIVITYNAME { get; set; }

		[JsonProperty]
		public uint? ALLOWREASSIGNMENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEEID { get; set; }

		[JsonProperty]
		public uint? ASSIGNEEOPTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEEROLEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ATTACHMENTSID { get; set; }

		[JsonProperty]
		public uint? AUTOCOMPLETE { get; set; }

		[JsonProperty]
		public uint? AUTOCOMPLETEFAILURE { get; set; }

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

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBYGMT { get; set; }

		[JsonProperty]
		public uint? COMPLETEWITHINQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(12,6)")]
		public decimal? COMPLETEWITHINUOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPLETIONATTACHMENTSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMPLETIONCOMMENTS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DATAPOINTCOLLECTIONID { get; set; }

		[JsonProperty]
		public uint? DEFAULTASSIGNEEINFO { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DESIGNATED { get; set; }

		[JsonProperty]
		public uint? DISPLAYCONFORMINGQUANTITY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DISPOSITIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTROUTEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTROUTEDONGMT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISREQUIRED { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTCOMPLETEDBYID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDESIGNATEDON { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDESIGNATEDONGMT { get; set; }

		[JsonProperty]
		public uint? LASTSTAGE { get; set; }

		[JsonProperty]
		public uint? OUTSTANDINGDETAILSTATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string REASSIGNMENTCOMMENTS { get; set; }

		[JsonProperty]
		public uint? RECONCILEQUANTITY { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SETUPACCESSID { get; set; }

		[JsonProperty]
		public uint? STAGE { get; set; }

	}

}
