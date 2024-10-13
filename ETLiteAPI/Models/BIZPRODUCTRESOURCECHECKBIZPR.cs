using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_PRODUCTRESOURCECHECKBIZ_PR", DisableSyncStructure = true)]
	public partial class BIZPRODUCTRESOURCECHECKBIZPR {

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZPRODUCTRESOURCECHECKID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTRESOURCECHECKDETID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTRESOURCECHECKDETID { get; set; }

	}

}
