using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZSVCTAGSNPRINTBIZSVCTAGSNP {

		[JsonProperty, Column(Name = "BIZ_SVCTAGSNPRINTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZSVCTAGSNPRINTID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "BIZ_SVCTAGSNPRINTHISTORYID", DbType = "CHAR(16 BYTE)")]
		public string BIZSVCTAGSNPRINTHISTORYID { get; set; }

	}

}
