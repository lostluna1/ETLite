using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "A_JOBMODELDETAILTOSTAGE", DisableSyncStructure = true)]
	public partial class AJOBMODELDETAILTOSTAGE {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string JOBMODELDETAILTOSTAGEID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string JOBMODELDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOSTAGEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(4000 BYTE)")]
		public string TOSTAGESELECTOR { get; set; }

		[JsonProperty]
		public uint? TOSTAGESEQUENCE { get; set; }

	}

}
