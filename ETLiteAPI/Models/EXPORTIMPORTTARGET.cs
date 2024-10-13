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
	public partial class EXPORTIMPORTTARGET {

		[JsonProperty, Column(IsPrimary = true)]
		public uint EXPORTIMPORTTARGETID { get; set; }

		[JsonProperty]
		public uint? EXPORTIMPORTHEADERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TARGETSYSTEMID { get; set; }

		[JsonProperty]
		public uint? TRACKABLEOBJECTCDOTYPEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TRACKABLEOBJECTID { get; set; }

	}

}
