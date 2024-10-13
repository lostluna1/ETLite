using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_VERSIONLIST", DisableSyncStructure = true)]
	public partial class BIZVERSIONLIST {

		[JsonProperty, Column(Name = "BIZ_VERSIONLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZVERSIONLISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BASEOBJECTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_VERSIONLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZVERSIONLISTNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string BOMID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVEFROMDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? EFFECTIVETHROUGHDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPBOMID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ERPROUTEID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PRODUCTIONVERSION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string WORKFLOWID { get; set; }

	}

}
