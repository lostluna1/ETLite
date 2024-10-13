using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "BIZ_MANPOWERBIZ_MANPOWERLIST", DisableSyncStructure = true)]
	public partial class BIZMANPOWERBIZMANPOWERLIST {

		[JsonProperty, Column(Name = "BIZ_MANPOWERID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZMANPOWERID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_MANPOWERLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZMANPOWERLISTID { get; set; }

	}

}
