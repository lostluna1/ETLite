using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_LAITASKDETAIL", DisableSyncStructure = true)]
	public partial class BIZLAITASKDETAIL {

		[JsonProperty, Column(Name = "BIZ_LAITASKDETAILID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZLAITASKDETAILID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CHECKREASONID", DbType = "CHAR(16 BYTE)")]
		public string BIZCHECKREASONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAITASKDETAILNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZLAITASKDETAILNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAITASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZLAITASKID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SAMPLETEST { get; set; }

	}

}
