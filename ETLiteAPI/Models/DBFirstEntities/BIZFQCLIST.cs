using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZFQCLIST {

		[JsonProperty, Column(Name = "BIZ_FQCLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZFQCLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCINSPECTIONTASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZFQCINSPECTIONTASKID { get; set; }

		[JsonProperty, Column(Name = "BIZ_FQCLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZFQCLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

	}

}
