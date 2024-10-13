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
	public partial class RECIPEITEM {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RECIPEITEMID { get; set; }

		[JsonProperty]
		public uint? ADVANCETONEXTTASK { get; set; }

		[JsonProperty]
		public uint? ALLOWMANUALWEIGHOVERRIDE { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string DOCUMENTSETID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ESIGREQUIREMENTID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string INSTRUCTION { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISMANUALREADINGONLY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string MANUALWEIGHESIGREQUIREMENTID { get; set; }

		[JsonProperty]
		public uint? MAXITERATIONS { get; set; }

		[JsonProperty]
		public uint? MINITERATIONS { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string RECIPEITEMNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPELISTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECIPEMATERIALLISTITEMID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string REPORTINSTRUCTION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SCALESID { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty]
		public uint? TASKTYPE { get; set; }

		[JsonProperty]
		public uint? TASKUSAGE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQGROUPID { get; set; }

		[JsonProperty]
		public uint? USEMATERIALFROMBATCH { get; set; }

	}

}
