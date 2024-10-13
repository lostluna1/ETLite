using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(Name = "ES_ADDRESSASSIGNHISTORYDETAIL", DisableSyncStructure = true)]
	public partial class ESADDRESSASSIGNHISTORYDETAIL {

		[JsonProperty, Column(Name = "ES_ADDRESSASSIGNHISTORYDETAIID", DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ESADDRESSASSIGNHISTORYDETAIID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(Name = "ES_ADDRESSASSIGNHISTORYDETNAME", DbType = "VARCHAR2(36 BYTE)")]
		public string ESADDRESSASSIGNHISTORYDETNAME { get; set; }

		[JsonProperty, Column(Name = "ES_ADDRESSPOOLID", DbType = "CHAR(16 BYTE)")]
		public string ESADDRESSPOOLID { get; set; }

		[JsonProperty, Column(Name = "ES_PHYSICALADDRESSID", DbType = "CHAR(16 BYTE)")]
		public string ESPHYSICALADDRESSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYDETAILSID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
