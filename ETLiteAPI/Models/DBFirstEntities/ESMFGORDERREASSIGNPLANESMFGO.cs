using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESMFGORDERREASSIGNPLANESMFGO {

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESMFGORDERREASSIGNPLANID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint FIELDID { get; set; }

		[JsonProperty, Column(IsPrimary = true)]
		public uint SEQUENCE { get; set; }

		[JsonProperty, Column(Name = "ES_MFGORDERREASSIGNPLANDETAIID", DbType = "CHAR(16 BYTE)")]
		public string ESMFGORDERREASSIGNPLANDETAIID { get; set; }

	}

}
