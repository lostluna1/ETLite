using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESJOBBOMS {

		[JsonProperty, Column(Name = "ES_JOBBOMSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESJOBBOMSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_BOMID", DbType = "CHAR(16 BYTE)")]
		public string ESBOMID { get; set; }

		[JsonProperty, Column(Name = "ES_JOBBOMSNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESJOBBOMSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
