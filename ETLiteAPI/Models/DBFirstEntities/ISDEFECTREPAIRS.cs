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
	public partial class ISDEFECTREPAIRS {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CHILDID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsNullable = false)]
		public string ISDEFECTHISTORYDETAILID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISDEFECTREASONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string ISREFDES { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISREPAIRACTIONID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ISREPAIRACTIONNAME { get; set; }

		[JsonProperty]
		public uint? ISX { get; set; }

		[JsonProperty]
		public uint? ISY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PRODUCTID { get; set; }

	}

}
