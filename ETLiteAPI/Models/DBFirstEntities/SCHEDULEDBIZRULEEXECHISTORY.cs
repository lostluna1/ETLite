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
	public partial class SCHEDULEDBIZRULEEXECHISTORY {

		[JsonProperty, Column(IsPrimary = true)]
		public uint SCHEDULEDBIZRULEEXECHISTORYID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(2000 BYTE)")]
		public string COMPLETIONMSG { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EXECUTIONCONTEXT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string EXECUTIONCONTEXTDISPLAYNAME { get; set; }

		[JsonProperty]
		public uint? EXECUTIONCONTEXTTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string EXECUTIONCONTEXTTYPENAME { get; set; }

		[JsonProperty]
		public uint? EXECUTIONSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXECUTIONTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EXECUTIONTIMEGMT { get; set; }

		[JsonProperty]
		public uint? ISSYSTEMDEFINED { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEXTEXECUTIONTIME { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? NEXTEXECUTIONTIMEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ONEXECUTE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCHEDULEDBIZRULE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SCHEDULEDBIZRULENAME { get; set; }

	}

}
