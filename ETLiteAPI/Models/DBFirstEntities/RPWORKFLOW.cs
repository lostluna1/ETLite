using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_WORKFLOW", DisableSyncStructure = true)]
	public partial class RPWORKFLOW {

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FASTCYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string FORMSTEPID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FORWARDCYCLETIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FORWARDYIELD { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISDEFAULT { get; set; }

		[JsonProperty]
		public uint? ISLASTSTEP { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NORMALCYCLETIME { get; set; }

		[JsonProperty]
		public uint? RUNRATEOPTION { get; set; }

		[JsonProperty]
		public uint? SEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECBASEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDBATCHSIZE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TIMEPERBATCH { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSTEPID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UNSCHEDULEDTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string WORKFLOWID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string WORKFLOWNAME { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(46 BYTE)")]
		public string WORKFLOWSTEPNAME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELD { get; set; }

	}

}
