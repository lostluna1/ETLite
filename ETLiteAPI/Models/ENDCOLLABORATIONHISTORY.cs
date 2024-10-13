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
	public partial class ENDCOLLABORATIONHISTORY {

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)", IsPrimary = true, IsNullable = false)]
		public string ENDCOLLABORATIONHISTORYID { get; set; }

		[JsonProperty]
		public uint? CDOTYPEID { get; set; }

		[JsonProperty]
		public uint? CHANGECOUNT { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string EMPLOYEEID { get; set; }

		[JsonProperty, Column(DbType = "VARCHAR2(36 BYTE)")]
		public string EXPORTIMPORTKEY { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMROLEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string FROMUSERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string HISTORYMAINLINEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string INTEGRATIONTXNID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string PROCESSOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string QUALITYOBJECTID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOROLEID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TOUSERID { get; set; }

		[JsonProperty, Column(DbType = "CHAR(16 BYTE)")]
		public string TXNID { get; set; }

	}

}
