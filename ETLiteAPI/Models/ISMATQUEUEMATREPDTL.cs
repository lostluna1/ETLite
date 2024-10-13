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
	public partial class ISMATQUEUEMATREPDTL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISMATQUEUEMATREPDTLID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty]
		public uint? ISFROZEN { get; set; }

		[JsonProperty]
		public uint? ISMANUALREPLENISH { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISMATERIALQUEUEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISMATQUEUEMATREPDTLNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISPRODUCTID { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISREPLENISHQTY { get; set; }

		[JsonProperty]
		public uint? ISREQUESTSUBMITTED { get; set; }

		[JsonProperty]
		public uint? ISSEQUENCE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? ISTHRESHOLDQTY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string ISUOMID { get; set; }

	}

}
