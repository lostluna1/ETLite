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
	public partial class COLLABORATORENTRY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string COLLABORATORENTRYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ASSIGNEDCOLLABORATORID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? ASSIGNEDDATEGMT { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string COLLABORATORCOMMENTS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string COLLABORATORENTRYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COLLABORATORID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETEBYGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string COMPLETEDBYID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? COMPLETIONDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DELEGATIONTASKID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? DURATION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(12,6)")]
		public decimal? DURATIONUOM { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROLEID { get; set; }

		[JsonProperty]
		public uint? SHEETLEVEL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string SPECIALINSTRUCTIONS { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty]
		public uint? SUBSTITUTEOPTION { get; set; }

	}

}
