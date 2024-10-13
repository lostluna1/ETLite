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
	public partial class IMPORTHEADERDATA {

		[JsonProperty, Column(IsPrimary = true)]
		public uint IMPORTHEADERID { get; set; }

		[JsonProperty]
		public uint? IMPORTACTIONIFMODIFIED { get; set; }

		[JsonProperty]
		public uint? IMPORTIFEXISTS { get; set; }

		[JsonProperty]
		public uint? IMPORTSETHEADERID { get; set; }

	}

}
