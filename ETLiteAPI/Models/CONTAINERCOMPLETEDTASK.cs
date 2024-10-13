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
	public partial class CONTAINERCOMPLETEDTASK {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string CONTAINERCOMPLETEDTASKID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETIONTIMESTAMP { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETIONTIMESTAMPGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CURRENTSTATUSID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string LASTREVTXNID { get; set; }

		[JsonProperty]
		public uint? NBRTIMESPROCESSED { get; set; }

		[JsonProperty]
		public uint? PASS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TASKID { get; set; }

		[JsonProperty]
		public uint? TASKISMARKEDCOMPLETED { get; set; }

	}

}
