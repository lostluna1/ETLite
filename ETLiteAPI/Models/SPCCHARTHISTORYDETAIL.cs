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
	public partial class SPCCHARTHISTORYDETAIL {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string RECORDSPCCHARTVIOLATIONHISTDID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILEDIRECTORY { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(255 BYTE)")]
		public string FILENAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string RECORDSPCVIOLATIONSUMMARYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string SPCCHARTDEFID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(30 BYTE)")]
		public string SPCCHARTDEFNAME { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
