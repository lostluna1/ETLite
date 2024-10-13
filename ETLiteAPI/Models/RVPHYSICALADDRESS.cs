using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "RV_PHYSICALADDRESS", DisableSyncStructure = true)]
	public partial class RVPHYSICALADDRESS {

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string ADDRESSPOOL { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(6 BYTE)")]
		public string ADDRESSTYPE { get; set; }

		[JsonProperty, Column(DbType = "NUMBER(22)")]
		public decimal? CHILDCOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string CONTAINERNAME { get; set; }

		[JsonProperty, Column(Name = "ES_PCBNUMBER")]
		public uint? ESPCBNUMBER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string IDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(100 BYTE)")]
		public string PARENTCONTAINERIDENTIFIER { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(40 BYTE)")]
		public string PHYSICALADDRESS { get; set; }

	}

}
