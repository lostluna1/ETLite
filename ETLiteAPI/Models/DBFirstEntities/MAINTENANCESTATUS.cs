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
	public partial class MAINTENANCESTATUS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string MAINTENANCESTATUSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEDMAINTREQID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEEMAILDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? DUEEMAILDATEGMT { get; set; }

		[JsonProperty]
		public uint? DUEEMAILSENT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTMAINTDATEDUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? FIRSTMAINTDATEDUEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEDUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTDATEDUEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LASTTHRUPUTQTY2 { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MAINTCOMPLETIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? MAINTCOMPLETIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEXTDATEDUE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEXTDATEDUEGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PASTDUEEMAILDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PASTDUEEMAILDATEGMT { get; set; }

		[JsonProperty]
		public uint? PASTDUEEMAILSENT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PENDINGEMAILDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? PENDINGEMAILDATEGMT { get; set; }

		[JsonProperty]
		public uint? PENDINGEMAILSENT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REASONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string STATUSID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTQTY2ADJUSTMENT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? THRUPUTQTYADJUSTMENT { get; set; }

	}

}
