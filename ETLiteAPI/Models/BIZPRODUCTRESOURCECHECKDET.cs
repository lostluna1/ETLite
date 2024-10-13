using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_PRODUCTRESOURCECHECKDET", DisableSyncStructure = true)]
	public partial class BIZPRODUCTRESOURCECHECKDET {

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKDETID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPRODUCTRESOURCECHECKDETID { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKDENAME", DbType = "VARCHAR2(256 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKDENAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISLIFETIMEUPDATED { get; set; }

		[JsonProperty]
		public uint? ISMAINRESOURCE { get; set; }

		[JsonProperty]
		public uint? ISVERIFYDAILYINSPECT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARTFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RESOURCEFAMILYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOOLFAMILYID { get; set; }

	}

}
