using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class ESJOBDOCUMENTS {

		[JsonProperty, Column(Name = "ES_JOBDOCUMENTSID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESJOBDOCUMENTSID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_DOCUMENTID", DbType = "CHAR(16 BYTE)")]
		public string ESDOCUMENTID { get; set; }

		[JsonProperty, Column(Name = "ES_JOBDOCUMENTSNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESJOBDOCUMENTSNAME { get; set; }

		[JsonProperty, Column(Name = "ES_NPIJOBID", DbType = "CHAR(16 BYTE)")]
		public string ESNPIJOBID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
