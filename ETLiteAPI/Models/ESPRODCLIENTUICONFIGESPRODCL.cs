using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_PRODCLIENTUICONFIGES_PRODCL", DisableSyncStructure = true)]
	public partial class ESPRODCLIENTUICONFIGESPRODCL {

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESPRODCLIENTUICONFIGID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "ES_PRODCLIENTUICONFIGDETAILSID", DbType = "CHAR(16 BYTE)")]
		public string ESPRODCLIENTUICONFIGDETAILSID { get; set; }

	}

}
