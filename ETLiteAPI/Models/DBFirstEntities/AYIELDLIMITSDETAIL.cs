using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "A_YIELDLIMITSDETAIL", DisableSyncStructure = true)]
	public partial class AYIELDLIMITSDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string YIELDLIMITSDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? DETAILSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOWERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? LOWERLIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UPPERLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? UPPERLIMIT2 { get; set; }

		[JsonProperty]
		public uint? YIELDASPECT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDCUTLIMIT { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? YIELDCUTLIMIT2 { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string YIELDLIMITSID { get; set; }

	}

}
