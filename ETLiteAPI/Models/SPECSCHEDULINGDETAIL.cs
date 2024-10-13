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
	public partial class SPECSCHEDULINGDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string SPECSCHEDULINGDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? DURATIONPERUNIT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? FASTCYCLETIME { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? NORMALCYCLETIME { get; set; }

		[JsonProperty]
		public uint? RUNRATEOPTION { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? SETUPTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? STDBATCHSIZE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TIMEPERBATCH { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UNITSPERHOUR { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UNSCHEDULEDTIME { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELD { get; set; }

	}

}
