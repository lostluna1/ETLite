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
	public partial class SECURITYMASKDETAIL {

		[JsonProperty, Column(IsPrimary = true)]
		public uint SECURITYMASKDETAILID { get; set; }

		[JsonProperty]
		public uint? BITNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty]
		public uint? DISPLAYTEXTLABELID { get; set; }

		[JsonProperty]
		public uint? SECURITYMASKID { get; set; }

	}

}
