using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_WORKFLOWTABLEAUDITLOG", DisableSyncStructure = true)]
	public partial class SYSWORKFLOWTABLEAUDITLOG {

		[JsonProperty, Column(StringLength = 50, IsPrimary = true, IsNullable = false)]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? AUDITDATE { get; set; }

		[JsonProperty]
		public int? AUDITID { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string AUDITOR { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string AUDITRESULT { get; set; }

		[JsonProperty]
		public int? AUDITSTATUS { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATEDATE { get; set; }

		[JsonProperty, Column(StringLength = -2)]
		public string REMARK { get; set; }

		[JsonProperty, Column(StringLength = 100)]
		public string STEPID { get; set; }

		[JsonProperty, Column(StringLength = 200)]
		public string STEPNAME { get; set; }

		[JsonProperty, Column(Name = "WORKFLOWTABLE_ID", StringLength = 50)]
		public string WORKFLOWTABLEID { get; set; }

		[JsonProperty, Column(Name = "WORKFLOWTABLESTEP_ID", StringLength = 50)]
		public string WORKFLOWTABLESTEPID { get; set; }

	}

}
