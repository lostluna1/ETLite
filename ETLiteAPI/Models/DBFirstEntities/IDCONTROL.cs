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
	public partial class IDCONTROL {

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)", IsPrimary = true, IsNullable = false)]
		public string IDTYPE { get; set; }

		[JsonProperty]
		public uint? NEXTID { get; set; }

		[JsonProperty]
		public uint? NOSKIP { get; set; }

	}

}
