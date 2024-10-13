using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RP_EQPT_LIFETIME", DisableSyncStructure = true)]
	public partial class RPEQPTLIFETIME {

		[JsonProperty, Column(Name = "BIZ_LIFETIMELIMIT")]
		public uint? BIZLIFETIMELIMIT { get; set; }

		[JsonProperty, Column(Name = "BIZ_USAGE")]
		public uint? BIZUSAGE { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string DESCRIPTION { get; set; }

		[JsonProperty, Column(Name = "REMAIN_QTY", DbType = "NUMBER(22)")]
		public decimal? REMAINQTY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string RESOURCENAME { get; set; }

	}

}
