using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZATETESTFLOWBIZATETESTFLOW {

		[JsonProperty, Column(Name = "BIZ_ATETESTFLOWID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZATETESTFLOWID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_ATETESTFLOWDETAILID", DbType = "CHAR(16 BYTE)")]
		public string BIZATETESTFLOWDETAILID { get; set; }

	}

}
