using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZLABELSETUPLIST {

		[JsonProperty, Column(Name = "BIZ_LABELSETUPLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZLABELSETUPLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABELDEFINITIONID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABELDEFINITIONID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABELPRINTSETUPID", DbType = "CHAR(16 BYTE)")]
		public string BIZLABELPRINTSETUPID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LABELSETUPLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZLABELSETUPLISTNAME { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CUSTOMERID { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPECID { get; set; }

	}

}
