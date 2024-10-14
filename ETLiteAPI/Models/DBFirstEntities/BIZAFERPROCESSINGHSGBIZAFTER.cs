using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZAFERPROCESSINGHSGBIZAFTER {

		[JsonProperty, Column(Name = "BIZ_AFERPROCESSINGHSGID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZAFERPROCESSINGHSGID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_AFTERHSGPRERFIDLISTID", DbType = "CHAR(16 BYTE)")]
		public string BIZAFTERHSGPRERFIDLISTID { get; set; }

	}

}
