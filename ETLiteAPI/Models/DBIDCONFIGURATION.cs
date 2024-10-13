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
	public partial class DBIDCONFIGURATION {

		[JsonProperty, Column(IsPrimary = true)]
		public uint IDCOLUMN { get; set; }

		[JsonProperty]
		public uint? ESTIMATEDNUMBEROFSITES { get; set; }

		[JsonProperty]
		public uint? NUMBEROFBITSUSED { get; set; }

		[JsonProperty]
		public uint? WARNINGRANGE { get; set; }

	}

}
