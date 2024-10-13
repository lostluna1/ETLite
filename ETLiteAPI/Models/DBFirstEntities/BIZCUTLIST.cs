using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_CUTLIST", DisableSyncStructure = true)]
	public partial class BIZCUTLIST {

		[JsonProperty, Column(Name = "BIZ_CUTLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZCUTLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_CUTLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZCUTLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_STDTOLFORWIRECUTID", DbType = "CHAR(16 BYTE)")]
		public string BIZSTDTOLFORWIRECUTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? MAXLENTH { get; set; }

		[JsonProperty]
		public uint? MINLENTH { get; set; }

		[JsonProperty]
		public uint? TOLNEGATIVE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string TOLPOSITIVE { get; set; }

	}

}
