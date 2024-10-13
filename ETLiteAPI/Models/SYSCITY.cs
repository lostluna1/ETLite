using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "SYS_CITY", DisableSyncStructure = true)]
	public partial class SYSCITY {

		[JsonProperty, Column(StringLength = 20)]
		public string CITYCODE { get; set; }

		[JsonProperty]
		public int CITYID { get; set; }

		[JsonProperty, Column(StringLength = 30)]
		public string CITYNAME { get; set; }

		[JsonProperty, Column(StringLength = 20)]
		public string PROVINCECODE { get; set; }

	}

}
