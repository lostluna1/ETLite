using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "AS_PRODUCTPLAN", DisableSyncStructure = true)]
	public partial class ASPRODUCTPLAN {

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string ENDTIME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string MFGEQP { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string MFGORDER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string SPEC { get; set; }

		[JsonProperty, Column(DbType = "CHAR(0 BYTE)")]
		public string STARTTIME { get; set; }

	}

}
