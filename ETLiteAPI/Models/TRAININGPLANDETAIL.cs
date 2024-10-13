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
	public partial class TRAININGPLANDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string TRAININGPLANDETAILID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SUBTRAININGPLANID { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? TARGETTRAININGDATE { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGPLANID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQUIREMENTBASEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRAININGREQUIREMENTID { get; set; }

	}

}
