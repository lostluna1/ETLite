using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_FAIINSPECTIONTASKDETAIL", DisableSyncStructure = true)]
	public partial class BIZFAIINSPECTIONTASKDETAIL {

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKDETAILID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFAIINSPECTIONTASKDETAILID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CHECKREASONID", DbType = "CHAR(16 BYTE)")]
		public string BIZCHECKREASONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKDETAINAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZFAIINSPECTIONTASKDETAINAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_FAIINSPECTIONTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZFAIINSPECTIONTASKID { get; set; }

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
