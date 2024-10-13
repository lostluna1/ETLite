using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_METGNOLIST", DisableSyncStructure = true)]
	public partial class BIZMETGNOLIST {

		[JsonProperty, Column(Name = "BIZ_METGNOLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMETGNOLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_METGNOID", DbType = "CHAR(16 BYTE)")]
		public string BIZMETGNOID { get; set; }

		[JsonProperty, Column(Name = "BIZ_METGNOLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZMETGNOLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "COMBIN_QUANTITY", DbType = "NUMBER(22)")]
		public decimal? COMBINQUANTITY { get; set; }

		[JsonProperty, Column(Name = "COMBINE_QUALITY", DbType = "NUMBER(22)")]
		public decimal? COMBINEQUALITY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISVALID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string ZFORMAT { get; set; }

	}

}
