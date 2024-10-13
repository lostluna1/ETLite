using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class QUALITYOBJECT {

		[JsonProperty]
		public uint? CATEGORY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CLASSIFICATIONID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ORGANIZATION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string OWNER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRIORITYLEVEL { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSMODEL { get; set; }

		[JsonProperty]
		public uint? QUALITYOBJECTTYPE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATE { get; set; }

		[JsonProperty, Column(DbType = "DATE(7)")]
		public DateTime? REPORTEDDATEGMT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string REPORTER { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ROLE { get; set; }

		[JsonProperty]
		public uint? STATUS { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SUBCLASSIFICATIONID { get; set; }

		[JsonProperty]
		public uint? TRIAGECOMPLETE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? TYPE { get; set; }

	}

}
