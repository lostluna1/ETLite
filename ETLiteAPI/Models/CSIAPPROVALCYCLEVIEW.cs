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
	public partial class CSIAPPROVALCYCLEVIEW {

		[JsonProperty, Column(DbType = "VARCHAR2(12 BYTE)")]
		public string APPROVALCYCLE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string APPROVEDBY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COMMENTS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBYGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string DECISIONTYPE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string EMPLOYEENAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string GENERALINSTRUCTIONS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTCOMPLETEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTROUTEDONGMT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string NAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ROLENAME { get; set; }

		[JsonProperty]
		public uint? SHEETLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string SPECIALINSTRUCTIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(32 BYTE)")]
		public string STATUS { get; set; }

	}

}
