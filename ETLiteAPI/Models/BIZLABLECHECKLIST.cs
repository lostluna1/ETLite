using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_LABLECHECKLIST", DisableSyncStructure = true)]
	public partial class BIZLABLECHECKLIST {

		[JsonProperty, Column(Name = "BIZ_LABLECHECKLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZLABLECHECKLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKGROUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABLECHECKGROUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZLABLECHECKLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKPLANID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABLECHECKPLANID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string LABLEITEMNAME { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

	}

}
