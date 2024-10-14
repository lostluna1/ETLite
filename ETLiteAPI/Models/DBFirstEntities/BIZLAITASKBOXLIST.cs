using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models.DBFirstEntities {

	
	public partial class BIZLAITASKBOXLIST {

		[JsonProperty, Column(Name = "BIZ_LAITASK_BOXLISTID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string BIZLAITASKBOXLISTID { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAITASK_BOXLISTNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string BIZLAITASKBOXLISTNAME { get; set; }

		[JsonProperty, Column(Name = "BIZ_LAITASKID", DbType = "CHAR(16 BYTE)")]
		public string BIZLAITASKID { get; set; }

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
