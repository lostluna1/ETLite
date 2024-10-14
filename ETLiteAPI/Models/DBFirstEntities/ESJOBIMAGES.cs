using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESJOBIMAGES {

		[JsonProperty, Column(Name = "ES_JOBIMAGESID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESJOBIMAGESID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_IMAGEID", DbType = "CHAR(16 BYTE)")]
		public string ESIMAGEID { get; set; }

		[JsonProperty, Column(Name = "ES_JOBIMAGESNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESJOBIMAGESNAME { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
