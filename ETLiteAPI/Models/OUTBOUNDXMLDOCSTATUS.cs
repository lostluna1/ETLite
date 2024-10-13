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
	public partial class OUTBOUNDXMLDOCSTATUS {

		[JsonProperty, Column(IsPrimary = true)]
		public uint DOCID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string TXNID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? CREATIONDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? LASTACTIVITYDATE { get; set; }

		[JsonProperty]
		public uint? RETRYCOUNT { get; set; }

		[JsonProperty]
		public uint? STATUSCODEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRANSPORTID { get; set; }

	}

}
