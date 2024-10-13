using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_MODELMAPPRODUCTBIZ_PRODUCT", DisableSyncStructure = true)]
	public partial class BIZMODELMAPPRODUCTBIZPRODUCT {

		[JsonProperty, Column(Name = "BIZ_MODELMAPPRODUCTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMODELMAPPRODUCTID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_PRODUCTLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZPRODUCTLISTID { get; set; }

	}

}
