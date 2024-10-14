using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZITEMCHECKLLIST {

		[JsonProperty, Column(Name = "BIZ_ITEMCHECKLLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZITEMCHECKLLISTID { get; set; }

		[JsonProperty]
		public uint? BARCODELENGTH { get; set; }

		[JsonProperty, Column(Name = "BIZ_ITEMCHECKLLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZITEMCHECKLLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKGROUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABLECHECKGROUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABLECHECKTYPEID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABLECHECKTYPEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? CHECKENDPOSITION { get; set; }

		[JsonProperty]
		public uint? CHECKITEMSEQUENCE { get; set; }

		[JsonProperty]
		public uint? CHECKSTARTPOSITION { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string CHECKVALUE { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
