﻿using FreeSql.DatabaseModel;using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using FreeSql.DataAnnotations;

namespace ETLiteAPI.Models {

	[JsonObject(MemberSerialization.OptIn), Table(DisableSyncStructure = true)]
	public partial class ISLOADUNLOADCARRIERHISTORYDTL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ISLOADUNLOADCARRIERHISTORYDTID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string CONTAINERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string ISLOADUNLOADCARRIERHISTORYNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PARENTID { get; set; }

		[JsonProperty]
		public uint? SLOTPOSITION { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
