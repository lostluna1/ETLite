using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class SYSPROVINCE {

		[JsonProperty, Column(IsPrimary = true)]
		public int PROVINCEID { get; set; }

		[JsonProperty, Column(StringLength = 20, IsNullable = false)]
		public string PROVINCECODE { get; set; }

		[JsonProperty, Column(StringLength = 30, IsNullable = false)]
		public string PROVINCENAME { get; set; }

		[JsonProperty, Column(StringLength = 20)]
		public string REGIONCODE { get; set; }

	}

}
